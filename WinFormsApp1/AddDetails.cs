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

        private void submitBtn_Click(object sender, EventArgs e)
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


                    Program.WorkoutDayInfoList.Add(workOutdayInfo);

                    workoutType.Text = string.Empty;
                    workOutHours.Text = string.Empty;
                    weightBox.Text = string.Empty;
                    burntCalories.Text = string.Empty;

                    string message = "Data saved successfully!";
                    MessageBox.Show(message);
                }
                else
                {
                    MessageBox.Show("Workout hours, calories burnt and weight must be non-negative.");
                }
            }
            else
            {
                MessageBox.Show("Invalid input for workout hours or weight or calories burnt.");
            }
        }
    }
}
