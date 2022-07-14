
using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Доброе утро: программа определяет площадь прямоугольника со сторонами a и b.");
            Console.WriteLine("Введите длину сотроны a:");
            int storonaA = 0;
            int storonaB = 0;
            bool isValidValue = int.TryParse(Console.ReadLine(), out storonaA) & storonaA > 0;
            bool key = false;
            while (isValidValue  == false)
            {
                Console.WriteLine("");
            }
            do
            {

                try
                {
                    storonaA = Convert.ToInt32(Console.ReadLine());
                    key = true;
                    if (storonaA <= 0) { Console.WriteLine("Сторона должна быть положительным целым числом, больше 0!"); key = false; }
                }
                catch(Exception )
                { Console.WriteLine("Сторона должна быть положительным целым числом, больше 0!"); key = false; }
            } while (key != true);
            do
            {
                Console.WriteLine("Введите длину сотроны b:");
                try
                {
                    storonaB = Convert.ToInt32(Console.ReadLine());
                    key = true;
                    if (storonaB <= 0) {Console.WriteLine("Сторона должна быть положительным целым числом, больше 0!"); key = false; }
                }
                catch { Console.WriteLine("Сторона должна быть положительным целым числом, больше 0!"); key = false; }
            } while (key != true);
            Console.WriteLine($"Sab = {storonaA * storonaB}"); return;
        }
    }
}
