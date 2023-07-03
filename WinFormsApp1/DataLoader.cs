using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class DataLoader
    {
        public static List<WorkOutdayInfo> GenerateWorkoutData()
        {
            List<WorkOutdayInfo> workoutData = new List<WorkOutdayInfo>();

         
            WorkOutdayInfo workout1 = new WorkOutdayInfo();
            workout1.UserName = "Hasanga";
            workout1.Date = DateTime.Now.AddDays(-1);
            workout1.WorkoutType = "Cycling";
            workout1.WorkoutHours = 1;
            workout1.Weight = 71;
            workout1.BurntCalories = 101;
            workoutData.Add(workout1);

            
            WorkOutdayInfo workout2 = new WorkOutdayInfo();
            workout2.UserName = "Hasanga";
            workout2.Date = DateTime.Now.AddDays(-2);
            workout2.WorkoutType = "Swimming";
            workout2.WorkoutHours = 2;
            workout2.Weight = 72;
            workout2.BurntCalories = 102;
            workoutData.Add(workout2);

            WorkOutdayInfo workout3 = new WorkOutdayInfo();
            workout3.UserName = "Hasanga";
            workout3.Date = DateTime.Now.AddDays(-3);
            workout3.WorkoutType = "Jogging";
            workout3.WorkoutHours = 2;
            workout3.Weight = 73;
            workout3.BurntCalories = 103;
            workoutData.Add(workout3);

            WorkOutdayInfo workout4 = new WorkOutdayInfo();
            workout4.UserName = "Hasanga";
            workout4.Date = DateTime.Now.AddDays(-4);
            workout4.WorkoutType = "Cycling";
            workout4.WorkoutHours = 2;
            workout4.Weight = 70;
            workout4.BurntCalories = 100;
            workoutData.Add(workout4);

            WorkOutdayInfo workout5 = new WorkOutdayInfo();
            workout5.UserName = "Hasanga";
            workout5.Date = DateTime.Now.AddDays(-5);
            workout5.WorkoutType = "Cycling";
            workout5.WorkoutHours = 2;
            workout5.Weight = 75;
            workout5.BurntCalories = 105;
            workoutData.Add(workout5);


            return workoutData;
        }


        public static List<CheatMealInfo> GenerateCheatMealData()
        {
            List<CheatMealInfo> cheatMealData = new List<CheatMealInfo>();

            CheatMealInfo cheatMeal1 = new CheatMealInfo
            {
                UserName = "Hasanga",
                Date = DateTime.Now.AddDays(-1),
                CheatMealName = "Pizza",
                Weight = 0.2
            };
            cheatMealData.Add(cheatMeal1);

            CheatMealInfo cheatMeal2 = new CheatMealInfo
            {
                UserName = "Hasanga",
                Date = DateTime.Now.AddDays(-2),
                CheatMealName = "Burger",
                Weight = 0.15
            };
            cheatMealData.Add(cheatMeal2);

            CheatMealInfo cheatMeal3 = new CheatMealInfo
            {
                UserName = "Hasanga",
                Date = DateTime.Now.AddDays(-3),
                CheatMealName = "Ice Cream",
                Weight = 0.1
            };
            cheatMealData.Add(cheatMeal3);

            CheatMealInfo cheatMeal4 = new CheatMealInfo
            {
                UserName = "Hasanga",
                Date = DateTime.Now.AddDays(-4),
                CheatMealName = "Chocolate Cake",
                Weight = 0.18
            };
            cheatMealData.Add(cheatMeal4);

            CheatMealInfo cheatMeal5 = new CheatMealInfo
            {
                UserName = "Hasanga",
                Date = DateTime.Now.AddDays(-5),
                CheatMealName = "French Fries",
                Weight = 0.12
            };
            cheatMealData.Add(cheatMeal5);

            return cheatMealData;
        }



    }
}
