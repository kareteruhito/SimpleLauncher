using System.ComponentModel;
using System.Windows.Media;

using NxLib.Helper;

namespace SimpleLauncher;
public class AppItem
{
    public string Path { get; }
    public string DisplayName { get; }
    public ImageSource Icon { get; }

    public AppItem(string path, string displayName, ImageSource icon)
    {
        Path = path;
        DisplayName = displayName;
        Icon = icon;
    }

    public static AppItem FromPath(string path)
    {
        var name = System.IO.Path.GetFileNameWithoutExtension(path);
        var icon = IconHelper.GetIconImageSource(path);
        return new AppItem(path, name, icon);
    }
}