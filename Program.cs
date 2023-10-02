namespace ConsoleApp5
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("            Меню");
                Console.WriteLine(" --------------------------");
                Console.WriteLine("|- 1. Игра 'Угадай число'  |");
                Console.WriteLine("|- 2. Таблица умножения    |");
                Console.WriteLine("|- 3. Вывод делителей числа|");
                Console.WriteLine("|- 0. Выход                |");
                Console.WriteLine(" --------------------------");
                int a = int.Parse(Console.ReadLine());

                switch (a)
                {
                    case 1:
                        num();
                        break;
                    case 2:
                        umnozhenie();
                        break;
                    case 3:
                        findnum();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Неправильно выбрана программа, повторите ещё раз, пожалуйста.");
                        break;
                }
            }
        }
        static void num()
        {
            Random random = new Random();
            int Num = random.Next(1, 101);
            int pop = 0;
            Console.WriteLine("Это игра 'Угадай число'.");
            Console.WriteLine("Было загадано число от 1 до 100. Попробуйте угадать его.");

            while (true)
            {
                Console.Write("Вы думаете, что это число: ");
                int guess = int.Parse(Console.ReadLine());
                pop++;
                if (guess == Num)
                {
                    Console.WriteLine($"Поздравляем! Вы угадали число {Num} за {pop} попыток.");
                    return;
                }
                else if (guess < Num)
                {
                    Console.WriteLine("Число больше.");
                }
                else
                {
                    Console.WriteLine("Число меньше.");
                }
            }
        }
        static void umnozhenie()
        {
            Console.WriteLine("Таблица умножения:");
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write($"{i * j,4}");
                }
                Console.WriteLine();
            }
        }
        static void findnum()
        {
            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Делители данного числа: ");
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
        }
    }
}