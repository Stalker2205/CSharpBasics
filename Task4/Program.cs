using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Доброе утро: Введите число N и программа напечатает изображение состоящие из N строк");
            bool key = false;
            int N = 0;
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
            int schet = 1;
            int pos = 0;
            string space = new string(' ', 5);
            for (int i = 0; i < N; i++)
            {
                string otv = "*";
                pos = N - 1;
                for (int z = 0; z < schet; z++)
                {
                    string prob = "";

                    for (int j = 0; j != pos; j++)
                    {
                        prob += " ";
                    }
                    Console.WriteLine(prob + otv);
                    otv += "**";
                    pos--;

                }
                schet++;
            }
        }
    }
}
