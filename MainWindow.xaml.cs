using System.Windows;
using System.Windows.Input;
using NxLib.Helper;

namespace SimpleLauncher;


public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        var vm = new MainViewModel();

        this.DataContext = vm;

        Wiring.AcceptFiles(List, files =>
        {
            (DataContext as IMainViewModel)?.SetFile(files[0]);
        }, "exe"); 

        Wiring.Hotkey(this, Key.Delete, ModifierKeys.None,
        () =>
        {
            vm.DeleteSelected();
        });

        Wiring.Hotkey(this, Key.Up, ModifierKeys.Alt,
        () =>
        {
            vm.MoveSelectedUp();
        });

        Wiring.Hotkey(this, Key.Down, ModifierKeys.Alt,
        () =>
        {
            vm.MoveSelectedDown();
        });

    }
    private void ListViewItem_DoubleClick(object sender, MouseButtonEventArgs e)
    {
        if (this.DataContext is not MainViewModel) return;

        var vm = (MainViewModel)this.DataContext;
        vm.LaunchApp();
    }
}