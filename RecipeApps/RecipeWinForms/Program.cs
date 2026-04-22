using CPUFramework;
using System.Windows.Forms;
using System;
namespace RecipeWinForms
{
    internal static class Program
    {
        public static string connstring = "Server=tcp:dev-tobycpu.database.windows.net,1433;" +
            "Initial Catalog=RecipeDB;" +
            "Persist Security Info=False;" +
            "User ID=TobyR;" +
            "Password=Liron@123;" +
            "MultipleActiveResultSets=False;" +
            "Encrypt=True;" +
            "TrustServerCertificate=False;" +
            "Connection Timeout=30;";
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            SQLUtility.ConnectionString = connstring;
            Application.Run(new Search());
        }
    }
}