using System;
using System.Drawing;
using System.Windows.Forms;

namespace KeyboardMaster
{
    public partial class Form1 : Form
    {
        private Timer _myTimer;
        private Label testCharacter;

        private Point startPositionForCharacter;
        private int _fallingSpeed;

        public Form1()
        {
            InitializeComponent();
            InitializeCustomLoop();
            InitializeSetupForCharacters();
        }

        private void InitializeSetupForCharacters()
        {
            _fallingSpeed = 1;
            startPositionForCharacter = new Point(testCharacter.Location.X, testCharacter.Location.Y);
        }

        private void InitializeCustomLoop()
        {
            _myTimer = new Timer();
            _myTimer.Tick += CustomLoop;
            _myTimer.Start();
        }

        private void CustomLoop(object sender, EventArgs e)
        {
            CharacterFalling();
        }

        private void CharacterFalling()
        {
            Point labelPoint = testCharacter.Location;
            labelPoint.Y += _fallingSpeed;
            testCharacter.Location = new Point(labelPoint.X, labelPoint.Y);
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);

            if (e.KeyCode == Keys.A)
            {
                testCharacter.Location = new Point(startPositionForCharacter.X, startPositionForCharacter.Y);
            }
        }
    }
}
