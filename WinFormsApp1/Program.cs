namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 

        public static List<WorkOutdayInfo> WorkoutDayInfoList { get; private set; } = new List<WorkOutdayInfo>();
        public static List<CheatMealInfo> CheatMealInfoList { get; private set; } = new List<CheatMealInfo>();
        public static Dictionary<string, string> UserCredentials { get; } = new Dictionary<string, string>()
        {
            { "Hasanga", "123456" },
            { "Lakdinu", "Karunadasa" }
        };

       [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            WorkoutDayInfoList = DataLoader.GenerateWorkoutData();
            CheatMealInfoList = DataLoader.GenerateCheatMealData();

            Application.Run(new UserLogin());


            


        }
    }
}