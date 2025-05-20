using Microsoft.EntityFrameworkCore;
using OnlineStore.Application.BusinessLogic;
using OnlineStore.Application.Models;
using OnlineStore.DataAccess;
using OnlineStore.Presentation;
using Application1 = System.Windows.Forms.Application; // Alias

namespace OnlineStore;

internal static class Program
{
    public static OnlineStoreDbContext OnlineStoreDbContext { get; private set; } = new();
    public static UserManager UserManager = new();
    public static ProductManager ProductManager = new();
    public static User CurrentLoggedIn = new();

    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        ApplyMigrations();

        ApplicationConfiguration.Initialize();
        Application1.Run(new LogIn());
    }

    private static void ApplyMigrations()
    {
        try
        {
            OnlineStoreDbContext.Database.Migrate();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Database migration failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Environment.Exit(1);
        }
    }
}