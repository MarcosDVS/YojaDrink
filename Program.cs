using YojaDrink.Interface.Context;
using YojaDrink.View;

namespace YojaDrink
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

            //Ensure database is created
            using (var ctx = new MyDbContext())
            {
                ctx.Database.EnsureCreated();
            }

            Application.Run(new frmIndex());
        }
    }
}