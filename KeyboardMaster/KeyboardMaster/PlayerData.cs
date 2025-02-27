
namespace KeyboardMaster
{
    internal struct PlayerData
    {
        public string Nick {  get; private set; }
        public string Scores {  get; private set; }

        public PlayerData(string nick, string scores)
        {
            Nick= nick;
            Scores= scores;
        }
    }
}
