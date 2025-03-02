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

            DataBaseControler.Initialize();

            ScorePopup scorePopup = new ScorePopup();
            scorePopup.Hide(); 

            GameOver gameOverPopup = new GameOver();
            GameOver.Instance.Hide();

            GameOverOfflineMode gameOverOfflineMode = new GameOverOfflineMode();
            GameOverOfflineMode.Instance.Hide();
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

        private void _scoreButton_Click(object sender, System.EventArgs e)
        {
            ScorePopup.Instance.Restart();
        }

        private void _okButton_Click(object sender, System.EventArgs e)
        {
            bool noDataBaseAddress = string.IsNullOrEmpty(connectionStringTextBox.Text);
            if (noDataBaseAddress)
            {
                MessageBox.Show("Enter data base address");
                return;
            }

            DataBaseControler.InitializeConnection(
                "Server=" + connectionStringTextBox.Text + ";" +
                "Database=Scores;" +
                "Trusted_Connection=True;");

            if (DataBaseControler.CanConnectToDatabase())
            {
                dataBaseConnectionStatusLabel.Text = connectionStringTextBox.Text;
                connectionStringTextBox.Visible = false;
                okButton.Visible = false;
            }
        }
    }
}
