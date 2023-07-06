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

        private void predictBtn_Click(object sender, EventArgs e)
        {
            double averageWorkoutHours = Program.WorkoutDayInfoList.Average(w => w.WorkoutHours);
            double averageWeight = Program.WorkoutDayInfoList.Average(w => w.Weight);

            // Calculate the total number of cheat meals and the average cheat meal weight for the available data
            int totalCheatMeals = Program.CheatMealInfoList.Count;
            double averageCheatMealWeight = Program.CheatMealInfoList.Average(c => c.Weight);

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
    }
}