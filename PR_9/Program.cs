using System;
public class Program
{
    public static void Main(string[] args)
    {
        for(; ;)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Здравствуйте!!!");
                Console.ForegroundColor = ConsoleColor.Cyan;
                double[] mass = new double[15];
                Console.WriteLine("Введите 15 вещественных чисел:");
                for (int i = 0; i < 15; i++)
                {
                    Console.Write($"Значение {i + 1}: ");
                    mass[i] = Convert.ToDouble(Console.ReadLine());
                }
                double minV = Math.Abs(mass[0]); // Предполагаем, что первый элемент - минимальный по модулю
                int minI = 0; // Индекс минимального по модулю элемента
                for (int i = 1; i < 15; i++)
                {
                    if (Math.Abs(mass[i]) < minV)
                    {
                        minV = Math.Abs(mass[i]);
                        minI = i;
                    }
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Минимальный по модулю элемент: {mass[minI]}");
            }
            catch (FormatException fex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Упс... Что-то пошло не так...");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Упс... Что-то пошло не так...");
                Console.ReadKey();
            }
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("Хотите выполнить команду еще раз? \nНажмите Y для продолжение программы, иначе любую другую кнопку для завершения!");
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                Console.Clear();
                continue;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Программа завершена. \tДо свидания!");
                Console.ReadKey();
                break;
            }
        }
        
    }
}

