using System.Windows.Forms;
using KeyboardMaster.Sql;

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

        internal void Restart(Player player, System.Collections.Generic.List<PlayerData> playerDataBase)
        {
            scoreListView.Items.Clear();
            nickTextBox.Text = string.Empty;
            LoadScoresFromDatabase(playerDataBase);
            Show();
            InitializeScore(player);

            Location = new System.Drawing.Point(
                ClientRectangle.Location.X + ClientRectangle.Width,
                ClientRectangle.Y / 2 + ClientRectangle.Height / 2);

            TopMost = true;
        }

        private void LoadScoresFromDatabase(System.Collections.Generic.List<PlayerData> playerDataBase)
        {
            ListViewItem listViewItem = new ListViewItem();
            foreach (PlayerData playerData in playerDataBase)
            {
                listViewItem = new ListViewItem();
                listViewItem.Text = playerData.Nick;
                listViewItem.SubItems.Add(playerData.Scores);
                scoreListView.Items.Add(listViewItem);
            }

            scoreListView.EndUpdate();
        }

        private void _okButton_Click(object sender, System.EventArgs e)
        {
            SaveToDataBase();
            Game.Instance.Hide();
            Hide();
            MainMenu.Instance.Show();
        }

        private void SaveToDataBase()
        {
            DataBaseControler.SaveScores(nickTextBox, _scoreValueLabel);
        }
    }
}
