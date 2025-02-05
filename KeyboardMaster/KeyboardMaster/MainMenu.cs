using System.Windows.Forms;

namespace KeyboardMaster
{
    public partial class MainMenu : Form
    {
        public static MainMenu Instance { get; private set; }

        public MainMenu()
        {
            InitializeComponent();
            Instance = this;

            Location = new System.Drawing.Point(
                (ScreenUtility.GetWidth(this) / 2) - (ClientRectangle.Width / 2),
            (ScreenUtility.GetHeight(this) / 2) - (ClientRectangle.Height / 2));
        }

        private void _newGameButton_Click(object sender, System.EventArgs e)
        {
            if (Game.Instance == null)
            {
                Game game = new Game();
            }

            Game.Instance.Restart();
            Hide();
        }

        private void _exitButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
