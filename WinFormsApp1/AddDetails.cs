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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class AddDetails : Form
    {
        public AddDetails()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private async void submitBtn_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value;
            string wrkoutType = workoutType.Text;
            int numOfWrkOutHrs;
            double weightOfUser;
            double caloriesBurnt;

            if (int.TryParse(workOutHours.Text, out numOfWrkOutHrs) && double.TryParse(weightBox.Text, out weightOfUser) && double.TryParse(burntCalories.Text, out caloriesBurnt))
            {
                if (numOfWrkOutHrs >= 0 && weightOfUser >= 0 && caloriesBurnt >= 0)
                {
                    WorkOutdayInfo workOutdayInfo = new WorkOutdayInfo
                    {
                        UserName = AppContext.LoggedInUsername,
                        Date = selectedDate,
                        WorkoutType = wrkoutType,
                        WorkoutHours = numOfWrkOutHrs,
                        Weight = weightOfUser,
                        BurntCalories = caloriesBurnt,
                    };

                    // Serialize workOutdayInfo to JSON
                    string json = JsonConvert.SerializeObject(workOutdayInfo);

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
                            HttpResponseMessage response = await client.PostAsync("FitnessService/Workout", new StringContent(json, Encoding.UTF8, "application/json"));

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

                    workoutType.Text = string.Empty;
                    workOutHours.Text = string.Empty;
                    weightBox.Text = string.Empty;
                    burntCalories.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Workout hours, calories burnt, and weight must be non-negative.");
                }
            }
            else
            {
                MessageBox.Show("Invalid input for workout hours or weight or calories burnt.");
            }
        }
    }
}
