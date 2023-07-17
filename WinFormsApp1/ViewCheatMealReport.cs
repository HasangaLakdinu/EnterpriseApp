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
    public partial class ViewCheatMealReport : Form
    {
        public ViewCheatMealReport()
        {
            InitializeComponent();
        }

        private async void ViewCheatMealReport_Load(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                // Set the base address of the API
                client.BaseAddress = new Uri("https://localhost:7205/apigateway/");

                try
                {
                    // Send a GET request to retrieve the cheat meal report data
                    HttpResponseMessage response = await client.GetAsync("FitnessService/CheatMeal");

                    // Check if the request was successful
                    if (response.IsSuccessStatusCode)
                    {
                        // Read the response content as JSON
                        string json = await response.Content.ReadAsStringAsync();

                        // Deserialize the JSON to a list of CheatMealInfo objects
                        List<CheatMealInfo> cheatMealInfoList = JsonConvert.DeserializeObject<List<CheatMealInfo>>(json);

                        // Bind the list to the cheatMealReport data source
                        cheatMealReport.DataSource = cheatMealInfoList;
                        cheatMealReport.Refresh();
                    }
                    else
                    {
                        string errorMessage = "Error occurred while retrieving the data. Status Code: " + response.StatusCode;
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
        }
    }
}
