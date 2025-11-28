using System.IO;
using System.Windows;

namespace SimpleLauncher;

public partial class App : Application
{
    public static string DataDir =>
        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SimpleLauncher");
    public static string PathsFile => Path.Combine(DataDir, "apps.txt");

    protected override void OnStartup(StartupEventArgs e)
    {
        Directory.CreateDirectory(DataDir);
        base.OnStartup(e);
    }
}

