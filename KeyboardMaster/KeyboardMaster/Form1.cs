using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KeyboardMaster
{
    public partial class Form1 : Form
    {
        private Timer _myTimer;

        private Label pointsLabel;
        private Label pointsValue;

        private Label chancesLabel;
        private Label chancesValueLabel;

        private Player _player;
        private List<Character> _characters;
        private int _fallingSpeed;

        public Form1()
        {
            RandomUtility.Initialize();

            InitializeComponent();
            InitializeCustomLoop();
            InitializeSetupForCharacters();
            InitializePlayerData();

            _characters = new List<Character>();
            SpawnCharacter();
        }

        private void InitializePlayerData()
        {
            _player = new Player(pointsValue, chancesValueLabel);
        }

        private void InitializeSetupForCharacters()
        {
            _fallingSpeed = 1;
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

        private void SpawnCharacter()
        {
            Character newCharacter = new Character(this);
            _characters.Add(newCharacter);
        }

        private void CharacterFalling()
        {
            for (int i = 0; i < _characters.Count; i++)
            {
                _characters[i].MoveDown(_fallingSpeed);

                if (_characters[i].IsOnBottom(this))
                {
                    _characters[i].RestoreRandomPosition(this);
                    _characters[i].SpawnAsNew();
                    _player.RemoveChance();
                }
            }
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);

            foreach (var character in _characters)
            {
                if (character.IsTheSameKey(e))
                {
                    character.RestoreRandomPosition(this);
                    character.SpawnAsNew();
                    _player.AddScore();
                }
            }
        }
    }
}
