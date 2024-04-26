using Otus_HW10_SOLID.Interfaces;

namespace Otus_HW10_SOLID
{
    public abstract class GameManager
    {
        protected int minValue;
        protected int maxValue;
        protected int lifeCount;

        private readonly INumberGenerator numberGenerator;
        private readonly INumberValidator numberValidator;

        public virtual int GetMin()
        {
            return minValue;
        }
        public virtual int GetMax()
        {
            return maxValue;
        }
        public virtual int GetLife()
        {
            return lifeCount;
        }
        public virtual string HelloMessage()
        {
            return "";
        }

        public GameManager(INumberGenerator generator, INumberValidator validator, int _minValue, int _maxValue, int _lifeCount)
        {
            numberGenerator = generator;
            numberValidator = validator;
            minValue = _minValue;
            maxValue = _maxValue ;
            lifeCount = _lifeCount;
        }

        public void StartGame()
        {
            int min = GetMin();
            int max = GetMax();
            int life = GetLife();

            int targetNumber = numberGenerator.GenerateNumber(min, max);
            Console.WriteLine(HelloMessage());
            numberValidator.SetNumber(targetNumber);
            int attempts = 0;
            string strGuess;
            int guess;

            Console.WriteLine($"Угадайте число от {min} до {max}");
            
            do
            {
                if (life <= 0)
                {
                    Console.WriteLine("Попытки закончились! Угадать число не удалось. Вы проиграли!");
                    break;
                }

                Console.Write($"Введите предполагаемое число: (у вас {life} попыток): ");

                strGuess = Console.ReadLine();
                try
                {
                    guess = int.Parse(strGuess);
                }
                catch
                {
                    Console.WriteLine("Необходимо ввести число!");
                    continue;
                }

                numberValidator.CompareNumber(guess);
                attempts++;
                life--;
            }
            while (!numberValidator.IsValid());

            if (numberValidator.IsValid())
            {
                Console.WriteLine($"Поздравляю! Число угадано с {attempts} попыток!");
            }
            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
