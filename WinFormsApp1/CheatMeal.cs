using Newtonsoft.Json;
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
    public partial class CheatMeal : Form
    {
        public CheatMeal()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = cheatMealDateTime.Value;
            string cheatMeal = cheatMealName.Text;
            string weightOfMealText = mealWeight.Text;

            if (string.IsNullOrWhiteSpace(cheatMeal))
            {
                MessageBox.Show("Cheat meal name cannot be empty.");
                return;
            }

            if (string.IsNullOrWhiteSpace(weightOfMealText))
            {
                MessageBox.Show("Weight of meal cannot be empty.");
                return;
            }

            if (!double.TryParse(weightOfMealText, out double weightOfMeal))
            {
                MessageBox.Show("Invalid weight of meal. Please enter a valid number.");
                return;
            }

            if (weightOfMeal < 0)
            {
                MessageBox.Show("Weight of meal cannot be negative.");
                return;
            }

            weightOfMeal /= 1000;

            CheatMealInfo cheatMealInfo = new CheatMealInfo
            {
                UserName = AppContext.LoggedInUsername,
                Date = selectedDate,
                CheatMealName = cheatMeal,
                Weight = weightOfMeal
            };

            // Serialize cheatMealInfo to JSON
            string json = JsonConvert.SerializeObject(cheatMealInfo);

            using (var client = new HttpClient())
            {
                // Set the base address of the API
                client.BaseAddress = new Uri("https://localhost:7205/apigateway/");

                // Set the content type to JSON
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    // Send a POST request to the desired endpoint with the JSON data
                    HttpResponseMessage response = await client.PostAsync("FitnessService/CheatMeal", new StringContent(json, Encoding.UTF8, "application/json"));

                    // Check if the request was successful
                    if (response.IsSuccessStatusCode)
                    {
                        string message = "Data saved successfully!";
                        MessageBox.Show(message);
                    }
                    else
                    {
                        string errorMessage = "Error occurred while saving the data. Status Code: " + response.StatusCode;
                        MessageBox.Show(errorMessage);
                    }
                }
                catch (HttpRequestException ex)
                {
                    // Handle any exceptions occurred during the request
                    string errorMessage = "An error occurred while sending the request: " + ex.Message;
                    MessageBox.Show(errorMessage);
                }
            }

            cheatMealName.Text = string.Empty;
            mealWeight.Text = string.Empty;
        }
    }
}
