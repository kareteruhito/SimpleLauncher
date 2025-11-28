
using System.Windows;
using System.Windows.Input;

namespace NxLib.Helper;
public static class Wiring
{
    public static void AcceptFiles(FrameworkElement el, Action<string[]> onFiles, params string[] exts)
    {
        el.AllowDrop = true;
        el.Drop += (_, e) =>
        {
            if (!e.Data.GetDataPresent(DataFormats.FileDrop)) return;

            var files = (string[])e.Data.GetData(DataFormats.FileDrop)!;

            if (exts is { Length: > 0 })
                files = files
                    .Where(f => exts.Any(x => f.EndsWith(x, StringComparison.OrdinalIgnoreCase)))
                    .ToArray();

            if (files.Length > 0)
                onFiles(files);
        };
    }

    public static void Hotkey(Window w, Key key, ModifierKeys mods, Action action, Func<bool>? canExecute = null)
    {
        var cmd = new RoutedUICommand();
        ExecutedRoutedEventHandler exec = (_, __) => action();
        CanExecuteRoutedEventHandler can = (_, e) => e.CanExecute = canExecute?.Invoke() ?? true;

        var cb = new CommandBinding(cmd, exec, can);
        var kb = new KeyBinding(cmd, key, mods);

        w.CommandBindings.Add(cb);
        w.InputBindings.Add(kb);
    }
}