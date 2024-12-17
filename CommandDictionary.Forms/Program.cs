using CommandDictionary.Data.Context;
using CommandDictionary.Data.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Windows.Forms;

namespace CommandDictionary.Forms;

internal static class Program
{
    public static IServiceProvider ServiceProvider { get; private set; }

    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        Application.SetHighDpiMode(HighDpiMode.SystemAware);
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        var serviceCollection = new ServiceCollection();
        ConfigureServices(serviceCollection);

        ServiceProvider = serviceCollection.BuildServiceProvider();

        var db = ServiceProvider.GetRequiredService<CommandsContext>();
        db.Database.Migrate();

        Application.Run(ServiceProvider.GetRequiredService<Main>());
    }

    private static void ConfigureServices(ServiceCollection services)
    {
        // Register your services here
        services.AddTransient<ICommandsContextRepository, CommandsContextRepository>();
        services.AddTransient<CommandsContext>();

        // Register your forms
        services.AddTransient<Main>();
        services.AddTransient<EditEntryForm>();
        services.AddTransient<NewEntryForm>();

    }
}
