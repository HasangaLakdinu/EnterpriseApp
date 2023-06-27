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

        private void button1_Click(object sender, EventArgs e)
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

            CheatMealInfo cheatMealInfo = new CheatMealInfo
            {
                UserName = AppContext.LoggedInUsername,
                Date = selectedDate,
                CheatMealName = cheatMeal,
                Weight = weightOfMeal

            };

            Program.CheatMealInfoList.Add(cheatMealInfo);

            cheatMealName.Text = string.Empty;
            mealWeight.Text = string.Empty;

            string message = "Data saved successfully!";
            MessageBox.Show(message);

        }
    }
}
