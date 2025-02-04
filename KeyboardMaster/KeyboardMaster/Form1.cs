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
        private const int _EACH_X_POINT_SPAWNS_ADDITIONAL_CHARACTER = 20;
        private const int _EACH_Y_POINT_INCREASES_FALLING_SPEED = 15;

        public Form1()
        {
            RandomUtility.Initialize();

            InitializeComponent();
            InitializeCustomLoop();
            InitializeSetupForCharacters();
            InitializePlayerData();
            SpawnCharacter();
        }


        private void InitializePlayerData()
        {
            _player = new Player(pointsValue, chancesValueLabel);
        }

        private void InitializeSetupForCharacters()
        {
            _characters = new List<Character>();
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

                    if (_player.GetScore() % _EACH_X_POINT_SPAWNS_ADDITIONAL_CHARACTER == 0)
                    {
                        SpawnCharacter();
                        return;
                    }

                    if (_player.GetScore() % _EACH_Y_POINT_INCREASES_FALLING_SPEED == 0)
                    {
                        _fallingSpeed++;
                        return;
                    }
                }
            }
        }
    }
}
