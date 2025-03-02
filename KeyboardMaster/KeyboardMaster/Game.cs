using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KeyboardMaster
{
    public partial class Game : Form
    {
        public static Game Instance { get; private set; }
        private Timer _loopTick;
        private uint _loopCounter;

        private Label pointsLabel;
        private Label pointsValue;

        private Label chancesLabel;
        private Label chancesValueLabel;

        private Player _player;
        private DifficultLevel _passiveDifficultLevel;
        private List<Character> _characters;
        private int _fallingSpeed;

        private int windowHeight;
        private int windowWidth;

        public Game()
        {
            InitalizeUtilities();
            InitializeComponent();
            InitializePlayer();
            InitializeGameLoop();
            InitializeSetupForCharacters();
            SpawnCharacter();
            InitializeSingleton();
            SetPositionToMiddleOfTheScreen();

            GameLoopTickRun();

            windowHeight = ClientRectangle.Height;
            windowWidth = ClientRectangle.Width;
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);

            int score;
            foreach (Character character in _characters)
            {
                if (character.HasTheSameKey(e))
                {
                    character.RandomPosition(windowWidth);
                    character.GetNewRandomValue();
                    _player.AddScore();
                    UpdateLabelPlayerPoints();
                    score = _player.GetScore();

                    if (_passiveDifficultLevel.CanIncreaseFallingSpeed(score))
                    {
                        _fallingSpeed++;
                        return;
                    }
                }
            }
        }

        public void Restart()
        {
            DeleteAllCharacters();
            InitializeSetupForCharacters();
            InitializePlayer();
            SpawnCharacter();
            GameLoopTickRun();
            Show();
        }

        private void GameLoopTickRun()
        {
            _loopTick.Start();
        }

        private void GameLoopTickStop()
        {
            _loopTick.Stop();
        }

        private void InitalizeUtilities()
        {
            RandomUtility.Initialize();
            ScreenUtility.Initialize();
            CharacterUtility.Initialize(65, 91);
        }

        private void SetPositionToMiddleOfTheScreen()
        {
            Location = new System.Drawing.Point(
                (ScreenUtility.GetWidth(this) / 2) - (ClientRectangle.Width / 2),
                (ScreenUtility.GetHeight(this) / 2) - (ClientRectangle.Height / 2));
        }

        private void InitializeSingleton()
        {
            Instance = this;
        }

        private void InitializeGameLoop()
        {
            _loopCounter = 0;
            _loopTick = new Timer();
            _loopTick.Tick += GameLoopTick;
        }

        private void InitializePlayer()
        {
            _player = new Player();
            _player.Initialize();
            UpdateLabelPlayerChance();
            UpdateLabelPlayerPoints();
        }

        private void UpdateLabelPlayerChance()
        {
            chancesValueLabel.Text = _player.Chances.ToString();
        }

        private void UpdateLabelPlayerPoints()
        {
            pointsValue.Text = _player.Points.ToString();
        }
        
        private void InitializeSetupForCharacters()
        {
            _characters = new List<Character>();
            InitializeCharacterDefaultSpeed();
        }

        private void InitializeCharacterDefaultSpeed()
        {
            _fallingSpeed = 1;
        }

        private void DeleteAllCharacters()
        {
            foreach (Character character in _characters)
            {
                Delete(character);
            }
        }

        private void Delete(Character character)
        {
            Label characterModel = character.Model;
            Controls.Remove(characterModel);
        }

        private void SpawnCharacter()
        {
            Character newCharacter = new Character(this);
            _characters.Add(newCharacter);
        }

        private void GameLoopTick(object sender, EventArgs e)
        {
            _loopCounter++;
            MoveCharactersDown();
            AreCharactersOnBottom();
            _isGameOver();

            if (_passiveDifficultLevel.CanAddCharacter(_loopCounter))
            {
                SpawnCharacter();
            }
        }

        private void MoveCharactersDown()
        {
            for (int i = 0; i < _characters.Count; i++)
            {
                _characters[i].MoveDown(_fallingSpeed);
            }
        }

        private void AreCharactersOnBottom()
        {
            windowHeight = ClientRectangle.Height;
            windowWidth = ClientRectangle.Width;

            for (int i = 0; i < _characters.Count; i++)
            {
                if (_characters[i].IsOnBottom(windowHeight))
                {
                    _characters[i].Spawn(windowWidth);
                    _player.RemoveChance();
                    UpdateLabelPlayerChance();
                }
            }
        }

        private void _isGameOver()
        {
            bool isGameOver = false;
            for (int i = 0; i < _characters.Count; i++)
            {
                isGameOver = _player.IsTheEndOfChances();
                if (isGameOver)
                {
                    CallGameOver();
                }
            }
        }

        private void CallGameOver()
        {
            GameLoopTickStop();

            if (!DataBaseControler.Connected)
            {
                GameOverOfflineMode.Instance.Show(_player);
                return;
            }

            var playerDataBase = DataBaseControler.LoadScores();
            GameOver.Instance.Restart(_player, playerDataBase);
        }
    }
}
