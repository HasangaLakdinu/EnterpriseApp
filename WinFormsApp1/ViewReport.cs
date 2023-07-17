using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ViewReport : Form
    {
        public ViewReport()
        {
            InitializeComponent();
        }

        private async void ViewReport_Load(object sender, EventArgs e)
        {


            using (var client = new HttpClient())
            {
                // Set the base address of the API
                client.BaseAddress = new Uri("https://localhost:7205/apigateway/");

                try
                {
                    // Send a GET request to retrieve the cheat meal report data
                    HttpResponseMessage response = await client.GetAsync("FitnessService/Workout");

                    // Check if the request was successful
                    if (response.IsSuccessStatusCode)
                    {
                        // Read the response content as JSON
                        string json = await response.Content.ReadAsStringAsync();

                        // Deserialize the JSON to a list of CheatMealInfo objects
                        List<WorkOutdayInfo> workOutInfoList = JsonConvert.DeserializeObject<List<WorkOutdayInfo>>(json);


                        var weeklyReports = workOutInfoList.GroupBy(w => CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(w.Date, CalendarWeekRule.FirstDay, DayOfWeek.Monday))
                        .Select(g => new WeeklyWorkoutReport
                        {
                            WeekNumber = g.Key,
                            TotalWorkoutHours = g.Sum(w => w.WorkoutHours),
                            AverageWeight = Math.Round(g.Average(w => w.Weight), 2),
                            TotalBurntCalories = g.Sum(w => w.BurntCalories)
                        })
                        .OrderBy(r => r.WeekNumber);

                        workoutReport.DataSource = weeklyReports.ToList();
                        workoutReport.Refresh();

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
