using System.Drawing;
using System.Windows.Forms;

namespace KeyboardMaster
{
    public class Character
    {
        private Label _model;
        private Point _position;
        private Keys _key;
        private int _fontSize;

        public Character(Game form)
        {
            _model = new Label();
            _model.Location = new Point(
                RandomUtility.Random(ScreenUtility.MinWidthAvailableForContent,
                    form.ClientRectangle.Width), 0);

            _fontSize = 18;
            _model.AutoSize = true;
            _model.Font = new Font("Calibri", _fontSize);
            _model.ForeColor = Color.Green;
             form.Controls.Add(_model);
            GetNewRandomValue();
            RestoreRandomPosition(form);
        }

        public void GetNewRandomValue()
        {
            RandomKey();
            SetValue();
        }

        private void RandomKey()
        {
            _key = CharacterUtility.RandomLetter();
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

        internal bool IsOnBottom(Game form)
        {
            return _position.Y > form.ClientRectangle.Height - _model.Size.Height;
        }

        internal void RestoreRandomPosition(Game form)
        {
            _position = new Point(
                RandomUtility.Random(
                    ScreenUtility.MinWidthAvailableForContent,
                    form.ClientRectangle.Width - _model.Size.Width), 0);

            _model.Location = new Point(_position.X, _position.Y);
        }

        internal void Delete(Control.ControlCollection controls)
        {
            controls.Remove(_model);
        }

        internal void Spawn(Game game)
        {
            RestoreRandomPosition(game);
            GetNewRandomValue();
        }
    }
}
