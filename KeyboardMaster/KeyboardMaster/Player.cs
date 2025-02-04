using System.Windows.Forms;

namespace KeyboardMaster
{
    internal struct Player
    {
        private int _chances;
        private int _points;

        private Label _pointsValue;
        private Label _chancesValueLabel;

        public Player(Label pointsValue, Label chancesValueLabel)
        {
            _chances = 4;
            _points = 0;

            _pointsValue = pointsValue;
            _chancesValueLabel = chancesValueLabel;
        }

        public int GetScore()
        {
            return _points;
        }

        public void AddScore()
        {
            _points++;
            UpdatePoints();
        }

        public void RemoveChance()
        {
            _chances--;
            UpdateChance();
        }

        private void UpdateChance()
        {
            _chancesValueLabel.Text = _chances.ToString();
        }

        private void UpdatePoints()
        {
            _pointsValue.Text = _points.ToString();
        }
    }
}
