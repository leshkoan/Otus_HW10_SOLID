namespace Otus_HW10_SOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var generator = new NumberGenerator();
            var validator = new NumberValidator();

            GameManager gameManager;
            
            Console.WriteLine("Введите уровень сложности: 1 - лёгкий, 2 - тяжёлый");
            string sChoice = Console.ReadLine();
            switch (sChoice)
            {
                case "1":
                    gameManager = new EasyModeGame(generator, validator);
                    break;
                case "2":
                    gameManager = new HardModeGame(generator, validator);
                    break;
                default:
                    Console.WriteLine("Необходимо ввести только либо 1, либо 2");
                    return;
            }
            gameManager.StartGame();
        }
    }
}