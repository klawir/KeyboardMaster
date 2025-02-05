using System.Windows.Forms;

namespace KeyboardMaster
{
    internal class ScreenUtility
    {
        internal static int GetHeight(Form windowForm)
        {
            return Screen.FromControl(windowForm).WorkingArea.Height;
        }

        internal static int GetWidth(Form windowForm)
        {
            return Screen.FromControl(windowForm).WorkingArea.Width;
        }
    }
}
