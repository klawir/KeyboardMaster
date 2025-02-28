using System;

namespace KeyboardMaster
{
    internal class Time
    {
        public static float DeltaTime { get; private set; }

        public static void Initialize()
        {
            var lastTime = DateTime.UtcNow;

            while (DeltaTime <= 0)
            {
                DateTime currentTime = DateTime.UtcNow;
                DeltaTime = (float)(currentTime - lastTime).TotalSeconds;
            }
        }
    }
}
