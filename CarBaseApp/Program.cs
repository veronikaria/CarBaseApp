using System;

namespace CarBaseApp
{
    class Program
    {
        private static CarBase[] car;
        private static int baseCount;

        static void indexInput()
        {
            int index;
            bool correct = false;
            try
            {
                do
                {
                    Console.Write("Введите номер автобазы для просмотра данных(<" + baseCount + "): ");
                    index = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    if (index > 0 && index <= baseCount)
                    {
                        index--;
                        correct = true;
                    }
                    else
                    {
                        Console.WriteLine("Введите корректные данные!");
                        Console.WriteLine();
                    }
                } while (!correct);
                CarBase.tableOutput();
                car[index].carBaseOutput();
                Console.WriteLine();
            }
            catch (Exception)
            {
                Console.WriteLine();
                Console.WriteLine("Введите корректные данные!");
                Console.WriteLine();
                indexInput();
            }
        }
        static void menu()
        {
            int number;
            try
            {
                Console.WriteLine("Меню:");
                Console.WriteLine("Вывести все данные об автобазах: 1");
                Console.WriteLine("Вывести данные об одной из автобаз: 2");
                Console.WriteLine("Выйти: 3");
                Console.WriteLine();

                Console.Write("Введите число: ");
                number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (number)
                {
                    case 1:
                        CarBase.tableOutput();
                        for (int i = 0; i < baseCount; i++)
                            car[i].carBaseOutput();
                        CarBase.outputGeneralAvarageVolume();
                        Console.WriteLine();
                        menu();
                        break;
                    case 2:
                        indexInput();
                        menu();
                        break;
                    case 3:
                        Console.WriteLine("Вы решили не продолжать!");
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("Введите корректные данные!");
                        Console.WriteLine();
                        menu();
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine();
                Console.WriteLine("Введите корректные данные!");
                Console.WriteLine();
                menu();
            }
        }
        static void Main(string[] args)
        {
            Random random = new Random();
            char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            String carBaseName = string.Empty;
            int letter, fuel, carQuantity;
            baseCount = random.Next(5, 20);
            car = new CarBase[baseCount];

            for (int i = 0; i < baseCount; i++)
            {
                fuel = random.Next(100, 10000);
                carQuantity = random.Next(10, 1000);
                for (int j = 0; j < 5; j++)
                {
                    letter = random.Next(0, letters.Length - 1);
                    carBaseName += letters[letter];
                }
                car[i] = new CarBase(fuel, carQuantity, carBaseName);
                carBaseName = string.Empty;
            }

            menu();
            Console.ReadKey();
        }
    }
}
