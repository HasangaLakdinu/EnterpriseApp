using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private async void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernamebox.Text;
            string password = passwordBox.Text;

            HttpClient client = new HttpClient();

            try
            {
                HttpResponseMessage response = await client.GetAsync($"https://localhost:7104/api/Login/{username}");

                if (response.IsSuccessStatusCode)
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    User credentials = JsonConvert.DeserializeObject<User>(apiResponse);

                    if (credentials != null && credentials.UserName == username && credentials.Password == password)
                    {
                        Form1 startingForm = new Form1();
                        startingForm.Show();
                        this.Hide();
                        AppContext.LoggedInUsername = username;
                    }
                    else
                    {
                        MessageBox.Show("Incorrect username or password!");
                    }
                }
                else
                {
                    MessageBox.Show("Error accessing the API!");
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show("Error connecting to the API: " + ex.Message);
            }
        }
    }
}
