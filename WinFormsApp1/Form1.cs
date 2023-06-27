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
            // Calculate the average workout hours and weight for the available data
            double averageWorkoutHours = Program.WorkoutDayInfoList.Average(w => w.WorkoutHours);
            double averageWeight = Program.WorkoutDayInfoList.Average(w => w.Weight);

            // Predict future fitness status based on average workout hours
            string fitnessStatus = averageWorkoutHours >= 2 ? "Good" : "Average";

            // Predict future weight based on average weight
            double predictedWeight = averageWeight - 1; // Assuming a 1-pound weight loss
            string formattedWeight = predictedWeight.ToString("0.00"); // Format weight to two decimal points

            // Display the predictions in a message box
            string message = $"Predicted Fitness Status: {fitnessStatus}\nPredicted Weight: {formattedWeight} kg";
            MessageBox.Show(message, "Fitness Prediction");
        }
    }
}