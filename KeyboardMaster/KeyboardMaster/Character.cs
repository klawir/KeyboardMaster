using System.Drawing;
using System.Windows.Forms;

namespace KeyboardMaster
{
    public class Character
    {
        private Label _model;
        private Point _position;
        private Keys _key;

        public Character(Form1 form)
        {
            _model = new Label();
            _model.Location = new Point(RandomUtility.Random(100, form.ClientRectangle.Width), 0);
            _model.AutoSize = true;
            _model.Font = new Font("Calibri", 18);
            _model.ForeColor = Color.Green;
            _model.Padding = new Padding(6);
            SpawnAsNew();
             form.Controls.Add(_model);
            RestoreRandomPosition(form);
        }

        public void SpawnAsNew()
        {
            RandomKey();
            SetValue();
        }

        private void RandomKey()
        {
            _key = (Keys)RandomUtility.Random(65, 91);
        }

        private void SetValue()
        {
            _model.Text = _key.ToString();
        }

        public void MoveDown(int fallingSpeed)
        {
            _position = _model.Location;
            _position.Y += fallingSpeed;
            _model.Location = new Point(_position.X, _position.Y);
        }

        public bool IsTheSameKey(KeyEventArgs e)
        {
            return _key == e.KeyCode;
        }

        internal bool IsOnBottom(Form1 form)
        {
            return _position.Y > form.ClientRectangle.Height - _model.Size.Height;
        }

        internal void RestoreRandomPosition(Form1 form)
        {
            _position = new Point(RandomUtility.Random(100, form.ClientRectangle.Width - _model.Size.Width), 0);
            _model.Location = new Point(_position.X, _position.Y);
        }
    }
}
