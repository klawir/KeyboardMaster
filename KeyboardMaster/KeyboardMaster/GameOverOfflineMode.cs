using System;
using System.Windows.Forms;

namespace KeyboardMaster
{
    public partial class GameOverOfflineMode : Form
    {
        public static GameOverOfflineMode Instance { get; private set; }

        public GameOverOfflineMode()
        {
            InitializeComponent();
            Instance = this;
            
            Location = new System.Drawing.Point(
                (ScreenUtility.GetWidth(this) / 2) - (ClientRectangle.Width / 2),
            (ScreenUtility.GetHeight(this) / 2) - (ClientRectangle.Height / 2));
        }

        protected override void OnShown(EventArgs e)
        {
            TopMost = true;
            base.OnShown(e);
        }

        private void backToMainMenu_Click(object sender, EventArgs e)
        {
            Game.Instance.Hide();
            Hide();
            MainMenu.Instance.Show();
        }
    }
}
