using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Доброе утро: Введите число N и программа напечатает изображение состоящие из N строк");
            bool key = false;
            int N = 0;
            string otv = "";
            do
            {
                try
                {
                    Console.WriteLine("Ввидите число N:");
                    N = Convert.ToInt32(Console.ReadLine());
                    key = true;
                    if (N <= 0) { key = false; }
                }
                catch { Console.WriteLine("Число должно быить положительным целым и больше 0"); key = false; }
            }
            while (key != true);


            for (int i = 0; i < N; i++)
            {
                otv += "*";
                Console.WriteLine(otv);
               // if (i == (N - 1)) { Console.Write(otv); }
            }
        }
    }
}
