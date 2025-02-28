using System.Windows.Forms;

namespace KeyboardMaster
{
    public partial class ScorePopup : Form
    {
        public static ScorePopup Instance { get; private set; }

        private int _clientRectangleOffset; 

        public ScorePopup()
        {
            InitializeComponent();
            Instance = this;

            Location = new System.Drawing.Point(
                (ScreenUtility.GetWidth(this) / 2) - GetWidthOfTheWindow,
            (ScreenUtility.GetHeight(this) / 2) - (ClientRectangle.Height / 2));

            _clientRectangleOffset = (ClientRectangle.Width / 10);
        }

        internal void Restart()
        {
            if (DataBaseControler.IsServerAddressEmpty())
            {
                MessageBox.Show("Enter data base address");
                return;
            }

            if (!DataBaseControler.Connected)
            {
                MessageBox.Show("No connection to data base");
                return;
            }

            scoreListView.Items.Clear();
            var playerDataBase = DataBaseControler.LoadScores();
            bool noConnactedToDataBase = playerDataBase.Count == 0;

            if (noConnactedToDataBase)
            {
                return;
            }

            LoadScoresFromDatabase(playerDataBase);
            Show();
        }

        private int GetWidthOfTheWindow
        {
            get
            {
                int width = ClientRectangle.Width;
                return (width / 2) - width - _clientRectangleOffset;
            }
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

        private void BackToMainMenu_Click(object sender, System.EventArgs e)
        {
            Hide();
        }
    }
}
