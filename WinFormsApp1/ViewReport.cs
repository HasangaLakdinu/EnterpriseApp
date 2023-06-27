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

        private void ViewReport_Load(object sender, EventArgs e)
        {
            var weeklyReports = Program.WorkoutDayInfoList.GroupBy(w => CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(w.Date, CalendarWeekRule.FirstDay, DayOfWeek.Monday))
                 .Select(g => new
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

    }
}
