using System;
using System.Drawing;
using System.Windows.Forms;

namespace KeyboardMaster
{
    public partial class Form1 : Form
    {
        private int _fallingSpeed;
        private Timer _myTimer;
        private System.Windows.Forms.Label label1;

        public Form1()
        {
            InitializeComponent();

            _myTimer = new Timer();
            _myTimer.Tick += CustomLoop;
            _myTimer.Start();
            _fallingSpeed = 1;
        }

        private void CustomLoop(object sender, EventArgs e)
        {
            Point labelPoint = label1.Location;
            labelPoint.Y += _fallingSpeed;
            label1.Location = new Point(labelPoint.X, labelPoint.Y);
        }

    }
}
