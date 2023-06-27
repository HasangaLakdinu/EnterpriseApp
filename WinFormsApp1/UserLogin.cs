using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernamebox.Text;
            string password = passwordBox.Text;

            if (Program.UserCredentials.ContainsKey(username))
            {
                if (Program.UserCredentials[username] == password)
                {
                    Form1 startingForm = new Form1();
                    startingForm.Show();
                    this.Hide();
                    AppContext.LoggedInUsername = username;
                }
                else
                {
                    MessageBox.Show("Incorrect password!");
                }
            }
            else
            {
                MessageBox.Show("Username not found!");
            }
        }
    }
}
