using Otus_HW10_SOLID.Interfaces;

namespace Otus_HW10_SOLID
{
    public class HardModeGame : GameManager
    {
        const int minInitValue = 0;
        const int maxInitValue = 200;
        const int lifeInitValue = 8;

        public override string HelloMessage()
        {
            return "Выбран сложный уровень игры.";
        }

        public HardModeGame(INumberGenerator generator, INumberValidator validator) : base(generator, validator, minInitValue, maxInitValue, lifeInitValue)
        {

        }
    }
}
