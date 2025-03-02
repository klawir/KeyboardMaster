
namespace KeyboardMaster
{
    public struct Player
    {
        public int Chances {  get; private set; }
        public int Points {  get; private set; }

        public void Initialize()
        {
            Chances = 4;
            Points = 0;
        }

        public bool IsTheEndOfChances()
        {
            return Chances == 0;
        }

        public int GetScore()
        {
            return Points;
        }

        public void AddScore()
        {
            Points++;
        }

        public void RemoveChance()
        {
            Chances--;
        }
    }
}
