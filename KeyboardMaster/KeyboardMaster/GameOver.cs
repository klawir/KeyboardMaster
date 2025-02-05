using System.Data;
using System.Data.SqlClient;
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
            scoreListView.Items.Clear();
            LoadScoresFromDatabase();

            textBox.Text = string.Empty;
            Show();
            InitializeScore(player);

            Location = new System.Drawing.Point(
                ClientRectangle.Location.X + ClientRectangle.Width,
                ClientRectangle.Y / 2 + ClientRectangle.Height / 2);

            TopMost = true;
        }

        private void LoadScoresFromDatabase()
        {
            SqlConnection connection = new SqlConnection("Server=DESKTOP-NT2DSL5\\SQLEXPRESS;Database=Scores;Trusted_Connection=True;");
            string oString = "Select Player,Value from Scores";
            SqlCommand oCmd = new SqlCommand(oString, connection);
            connection.Open();

            using (SqlDataReader oReader = oCmd.ExecuteReader())
            {
                while (oReader.Read())
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = oReader["Player"].ToString();
                    lvi.SubItems.Add(oReader["Value"].ToString());
                    scoreListView.Items.Add(lvi);
                }

                scoreListView.EndUpdate();
                connection.Close();
            }
        }

        private void _okButton_Click(object sender, System.EventArgs e)
        {
            SaveToDataBase();
            Game.Instance.Hide();
            GameOver.Instance.Hide();
            MainMenu.Instance.Show();
        }

        private void SaveToDataBase()
        {
            SqlConnection connection = new SqlConnection("Server=DESKTOP-NT2DSL5\\SQLEXPRESS;Database=Scores;Trusted_Connection=True;");

            string querySql = "INSERT INTO Scores (Player, Value) values (@Player, @Value)";
            connection.Open();
            SqlCommand queryExecution = new SqlCommand(querySql, connection);
            queryExecution.Parameters.Add("@Player", SqlDbType.VarChar);
            queryExecution.Parameters["@Player"].Value = textBox.Text;
            queryExecution.Parameters.Add("@Value", SqlDbType.Int);
            queryExecution.Parameters["@Value"].Value = int.Parse(_scoreValueLabel.Text);
            queryExecution.ExecuteNonQuery();
        }
    }
}
