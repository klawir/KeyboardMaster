using System.Windows.Forms;

namespace KeyboardMaster
{
    public partial class GameOver : Form
    {
        public static GameOver Instance { get; private set; }

        public GameOver()
        {
            InitializeComponent();
            Instance = this;

            Location = new System.Drawing.Point(
                (ScreenUtility.GetWidth(this) / 2) - (ClientRectangle.Width / 2),
            (ScreenUtility.GetHeight(this) / 2) - (ClientRectangle.Height / 2));
        }

        internal void InitializeScore(Player playerData)
        {
            _scoreValueLabel.Text = playerData.GetScore().ToString();
        }

        internal void Restart(Player player)
        {
            textBox1.Text = string.Empty;
            Show();
            InitializeScore(player);

            Location = new System.Drawing.Point(
                ClientRectangle.Location.X + ClientRectangle.Width,
                ClientRectangle.Y / 2 + ClientRectangle.Height / 2);

            TopMost = true;
        }

        private void _okButton_Click(object sender, System.EventArgs e)
        {
            Game.Instance.Hide();
            GameOver.Instance.Hide();
            MainMenu.Instance.Show();
        }
    }
}
