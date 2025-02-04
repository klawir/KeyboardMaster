using System.Windows.Forms;

namespace KeyboardMaster
{
    public partial class GameOver : Form
    {
        public GameOver()
        {
            InitializeComponent();
        }

        internal void InitializeScore(Player playerData)
        {
            _scoreValueLabel.Text = playerData.GetScore().ToString();
        }
    }
}
