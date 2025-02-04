
using System;

namespace KeyboardMaster
{
    internal static class RandomUtility
    {
        private static Random _random;

        public static void Initialize()
        {
            _random = new Random();
        }

        public static int Random(int min, int max)
        {
            return _random.Next(min, max);
        }
    }
}
