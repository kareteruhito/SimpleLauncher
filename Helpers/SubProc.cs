using System.Diagnostics;

namespace NxLib.Helper;

public static class SubProc
{
    public static bool Launch(string path)
    {
        bool result = true;
        try
        {
            Process.Start(new ProcessStartInfo(path) { UseShellExecute = true });
        }
        catch
        {
            result = false;
        }

        return result;
    }
}