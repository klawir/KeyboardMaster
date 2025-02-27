using System.Windows.Forms;

namespace KeyboardMaster
{
    internal class CharacterUtility
    {
        private static int _minAsciiForLetters;
        private static int _maxAsciiForLetters;

        public static void Initialize(int minAsciiForLetters, int maxAsciiForLetters)
        {
            _minAsciiForLetters = minAsciiForLetters;
            _maxAsciiForLetters = maxAsciiForLetters;
        }

        internal static Keys RandomLetter()
        {
            return (Keys)RandomUtility.Random(_minAsciiForLetters, _maxAsciiForLetters);
        }
    }
}
