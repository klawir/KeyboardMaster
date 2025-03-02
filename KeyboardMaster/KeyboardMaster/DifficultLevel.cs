
namespace KeyboardMaster
{
    internal struct DifficultLevel
    {
        private const int _TICK_AMOUNT_TO_SPAWNS_ADDITIONAL_CHARACTER = 500;
        private const int _POINT_AMOUNT_TO_INCREASE_FALLING_SPEED = 50;

        internal bool CanAddCharacter(uint time)
        {
            return time % _TICK_AMOUNT_TO_SPAWNS_ADDITIONAL_CHARACTER == 0;
        }

        internal bool CanIncreaseFallingSpeed(int score)
        {
            return score % _POINT_AMOUNT_TO_INCREASE_FALLING_SPEED == 0;
        }
    }
}
