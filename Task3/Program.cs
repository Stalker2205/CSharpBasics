using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Доброе утро: Введите число N и программа напечатает изображение состоящие из N строк");
            bool key = false;
            double pos = 0;
            int N = 0;
            string otv = "*";
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
            pos = N - 1;
            Math.Round(pos, 0);
            for (int i = 0; i < N; i++)
            {
                
                string prob = string.Empty;

                for (int j = 0; j != pos; j++)
                {
                    prob += " ";
                }
                Console.WriteLine(prob + otv);
                otv += "**";
                pos--;
             //   if ((N - i) == 1) { Console.Write(prob + otv); }

            }
            return;
        }
    }
}
