using System.Drawing;
using System.Windows.Forms;

namespace KeyboardMaster
{
    public class Character
    {
        private Point _position;
        private Keys _key;
        private int _fontSize;

        public Label Model { get; set; }

        public Character(Game form)
        {
            int windowWidth = form.ClientRectangle.Width;
            Model = new Label();
            Model.Location = new Point(
                RandomUtility.Random(ScreenUtility.MinWidthAvailableForContent,
                    windowWidth), 0);

            _fontSize = 18;
            Model.AutoSize = true;
            Model.Font = new Font("Calibri", _fontSize);
            Model.ForeColor = Color.Green;
            form.Controls.Add(Model);
            GetNewRandomValue();
            RandomPosition(windowWidth);
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
            Model.Text = _key.ToString();
        }

        public void MoveDown(int fallingSpeed)
        {
            _position = Model.Location;
            _position.Y += fallingSpeed;
            Model.Location = new Point(_position.X, _position.Y);
        }

        public bool HasTheSameKey(KeyEventArgs e)
        {
            return _key == e.KeyCode;
        }

        internal bool IsOnBottom(int windowHeight)
        {
            return _position.Y > windowHeight - Model.Size.Height;
        }

        internal void RandomPosition(int windowWidth)
        {
            _position = new Point(
                RandomUtility.Random(
                    ScreenUtility.MinWidthAvailableForContent,
                    windowWidth - Model.Size.Width), 0);

            Model.Location = new Point(_position.X, _position.Y);
        }

        internal void Spawn(int windowWidth)
        {
            RandomPosition(windowWidth);
            GetNewRandomValue();
        }
    }
}
