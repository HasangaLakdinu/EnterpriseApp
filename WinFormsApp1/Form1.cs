using Newtonsoft.Json;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void enterDetailsBtn_Click(object sender, EventArgs e)
        {
            AddDetails addDetailsForm = new AddDetails();
            addDetailsForm.Show();
        }


        private void cheatMealBtn_Click(object sender, EventArgs e)
        {
            CheatMeal cheatMealForm = new CheatMeal();
            cheatMealForm.Show();
        }

        private void workoutReportBtn_Click(object sender, EventArgs e)
        {
            ViewReport viewReportForm = new ViewReport();
            viewReportForm.Show();
        }

        private void reviewDetails_Click(object sender, EventArgs e)
        {

        }

        private void cheatMealReportBtn_Click(object sender, EventArgs e)
        {
            ViewCheatMealReport viewCheatMealReportForm = new ViewCheatMealReport();
            viewCheatMealReportForm.Show();
        }

        private async void predictBtn_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                // Set the base address of the API
                client.BaseAddress = new Uri("https://localhost:7205/apigateway/");

                try
                {
                    // Send the GET requests concurrently using Task.WhenAll
                    Task<HttpResponseMessage> cheatMealTask = client.GetAsync("FitnessService/CheatMeal");
                    Task<HttpResponseMessage> workoutTask = client.GetAsync("FitnessService/Workout");

                    // Wait for both requests to complete
                    await Task.WhenAll(cheatMealTask, workoutTask);

                    HttpResponseMessage cheatMealResponse = cheatMealTask.Result;
                    HttpResponseMessage workoutResponse = workoutTask.Result;

                    // Check if both requests were successful
                    if (cheatMealResponse.IsSuccessStatusCode && workoutResponse.IsSuccessStatusCode)
                    {
                        // Read the response content as JSON
                        string cheatMealJson = await cheatMealResponse.Content.ReadAsStringAsync();
                        string workoutJson = await workoutResponse.Content.ReadAsStringAsync();

                        List<WorkOutdayInfo> workOutInfoList = JsonConvert.DeserializeObject<List<WorkOutdayInfo>>(workoutJson);
                        List<CheatMealInfo> cheatMealInfoList = JsonConvert.DeserializeObject<List<CheatMealInfo>>(cheatMealJson);

                        double averageWorkoutHours = workOutInfoList.Average(w => w.WorkoutHours);
                        double averageWeight = workOutInfoList.Average(w => w.Weight);

                        // Calculate the total number of cheat meals and the average cheat meal weight for the available data
                        int totalCheatMeals = cheatMealInfoList.Count;
                        double averageCheatMealWeight = cheatMealInfoList.Average(c => c.Weight);

                        // Predict future fitness status based on average workout hours and total cheat meals
                        string fitnessStatus;
                        if (averageWorkoutHours >= 2 && totalCheatMeals < 3)
                        {
                            fitnessStatus = "Good";
                        }
                        else if (averageWorkoutHours >= 1 && totalCheatMeals < 5)
                        {
                            fitnessStatus = "Average";
                        }
                        else
                        {
                            fitnessStatus = "Poor";
                        }

                        // Predict future weight based on average weight and average cheat meal weight
                        double predictedWeight = averageWeight + (averageCheatMealWeight * 0.5); // Assuming a 0.5 kg weight gain per cheat meal

                        // Display the predictions in a message box
                        string message = $"Predicted Fitness Status: {fitnessStatus}\nPredicted Weight: {predictedWeight:F2} kg";
                        MessageBox.Show(message, "Fitness Prediction");
                    }
                    else
                    {
                        string errorMessage = "Error occurred while retrieving the data.";
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