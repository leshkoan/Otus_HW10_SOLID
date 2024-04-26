using Otus_HW10_SOLID.Interfaces;

namespace Otus_HW10_SOLID
{
    public class EasyModeGame : GameManager
    {
        const int minInitValue = 0;
        const int maxInitValue = 100;
        const int lifeInitValue = 15;

        public override string HelloMessage()
        {
            return "Выбран легкий уровень сложности игры.";
        }

        public EasyModeGame(INumberGenerator generator, INumberValidator validator) : base(generator, validator, minInitValue, maxInitValue, lifeInitValue)
        {

        }
    }
}
