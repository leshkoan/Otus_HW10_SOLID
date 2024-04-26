using Otus_HW10_SOLID.Interfaces;

namespace Otus_HW10_SOLID
{
    public class NumberValidator : INumberValidator
    {
        private int _randomNumber = -1;
        private bool _isValid = false;
        public bool CompareNumber(int currentNumber)
        {
            if (currentNumber > _randomNumber)
            {
                Console.WriteLine("Меньше...");
            }
            else if (currentNumber < _randomNumber)
            {
                Console.WriteLine("Больше...");
            }
            else
            {
                _isValid = true;
            }
            return _isValid;
        }

        public bool IsValid()
        {
            return _isValid;
        }

        public void SetNumber(int randomNumber)
        {
            _randomNumber = randomNumber;
        }
    }
}
