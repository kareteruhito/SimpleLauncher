
namespace SimpleLauncher;

public interface IMainViewModel
{
    void SetFile(string file);
    void DeleteSelected();
    void MoveSelectedUp();
    void MoveSelectedDown();
    void LaunchApp();
}