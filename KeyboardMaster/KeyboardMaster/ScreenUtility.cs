using System.Windows.Forms;

namespace KeyboardMaster
{
    internal class ScreenUtility
    {
        public static int MinWidthAvailableForContent {  get; private set; }

        public static void Initialize()
        {
            MinWidthAvailableForContent = 100;
        }

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
