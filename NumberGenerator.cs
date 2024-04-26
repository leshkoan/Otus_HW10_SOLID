using Otus_HW10_SOLID.Interfaces;

namespace Otus_HW10_SOLID
{
    public class NumberGenerator : INumberGenerator
    {
        private Random random = new Random();
        public int GenerateNumber(int min, int max)
        {
            return random.Next(min, max);
        }
    }
}
