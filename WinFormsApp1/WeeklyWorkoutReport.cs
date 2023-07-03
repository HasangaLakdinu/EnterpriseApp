using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class WeeklyWorkoutReport
    {
        public int WeekNumber { get; set; }
        public int TotalWorkoutHours { get; set; }
        public double AverageWeight { get; set; }
        public double TotalBurntCalories { get; set; }
    }
}
