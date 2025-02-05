using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KeyboardMaster
{
    public partial class Game : Form
    {
        public static Game Instance { get; private set; }
        private Timer _loopTick;

        private Label pointsLabel;
        private Label pointsValue;

        private Label chancesLabel;
        private Label chancesValueLabel;

        private Player _player;
        private DifficultLevel _passiveDifficultLevel;
        private List<Character> _characters;
        private int _fallingSpeed;

        public Game()
        {
            RandomUtility.Initialize();

            InitializeComponent();
            InitializeCustomLoop();
            InitializeSetupForCharacters();
            InitializePlayerData();
            SpawnCharacter();
            Instance = this;

            Location = new System.Drawing.Point(
                (ScreenUtility.GetWidth(this) / 2) - (ClientRectangle.Width / 2),
            (ScreenUtility.GetHeight(this) / 2) - (ClientRectangle.Height / 2));
        }

        public void Restart()
        {
            foreach (var item in _characters)
            {
                item.Delete(Controls);
            }

            InitializeSetupForCharacters();
            InitializePlayerData();
            SpawnCharacter();
            _loopTick.Start();
            Show();
        }

        private void InitializePlayerData()
        {
            _player = new Player(pointsValue, chancesValueLabel);
        }

        private void InitializeSetupForCharacters()
        {
            _characters = new List<Character>();
            _fallingSpeed = 10;
        }

        private void InitializeCustomLoop()
        {
            _loopTick = new Timer();
            _loopTick.Tick += CustomLoop;
            _loopTick.Start();
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

                    bool isGameOver = _player.IsTheEndOfChances();
                    if (isGameOver)
                    {
                        CallGameOver();
                    }
                }
            }
        }

        private void CallGameOver()
        {
            if (GameOver.Instance == null)
            {
                GameOver gameOverPopup = new GameOver();
            }

            GameOver.Instance.Restart(_player);
            _loopTick.Stop();
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);

            int score;
            foreach (var character in _characters)
            {
                if (character.IsTheSameKey(e))
                {
                    character.RestoreRandomPosition(this);
                    character.SpawnAsNew();
                    _player.AddScore();
                    score = _player.GetScore();

                    if (_passiveDifficultLevel.TryAddCharacter(score))
                    {
                        SpawnCharacter();
                        return;
                    }

                    if (_passiveDifficultLevel.TryIncreaseFallingSpeed(score))
                    {
                        _fallingSpeed++;
                        return;
                    }
                }
            }
        }
    }
}
