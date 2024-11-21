using Microsoft.EntityFrameworkCore;

namespace _10._3dbCRUD
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Data.Data.carContext = new Data.CarContext();
            Data.Data.carContext.Database.EnsureCreated();
            Data.Data.carContext.Cars.Load();
            Application.Run(new Form1());
        }
    }
}