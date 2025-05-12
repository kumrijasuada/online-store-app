using OnlineStore.Application.BusinessLogic;
using OnlineStore.Application.Models;
using OnlineStore.Presentation;
using Application1 = System.Windows.Forms.Application; // Alias

namespace OnlineStore;

internal static class Program
{
    public static UserManager UserManager = new();
    public static ProductManager ProductManager = new();
    public static User CurrentLoggedIn = new();
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application1.Run(new LogIn());
    }
}