
namespace KeyboardMaster
{
    internal struct DifficultLevel
    {
        private const int _EACH_X_POINT_SPAWNS_ADDITIONAL_CHARACTER = 10;
        private const int _EACH_Y_POINT_INCREASES_FALLING_SPEED = 25;

        internal bool TryAddCharacter(int score)
        {
            return score % _EACH_X_POINT_SPAWNS_ADDITIONAL_CHARACTER == 0;
        }

        internal bool TryIncreaseFallingSpeed(int score)
        {
            return score % _EACH_Y_POINT_INCREASES_FALLING_SPEED == 0;
        }
    }
}
