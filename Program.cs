using pitaya_crud.Utils;
using PitayaCompany;

namespace pitaya_crud;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        GlobalExceptionHandler.Initialize();
        ApplicationConfiguration.Initialize();
        Application.Run(new TelaLogin());
    }    
}