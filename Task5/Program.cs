using System;

namespace Task5
{
    class Program
    {
        private int x;

        static void Main(string[] args)
        {
            int sum = 0;
            int sis = 1000;
            for (int i = 0; i < sis; i++)
            {
                if ((i % 3 == 0) | (i % 5 == 0))
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
            int a = 1;
            int b = 2;

            int sum1 = a < b ? b == 0 ? 1 : 1 : a - b;

            string str = null;

            int? l = str?.Length;
            int[] array = { 1, 2, 3 };

            Console.WriteLine(array.GetUpperBound(0));

            Array array1 = Array.CreateInstance(typeof(int), 5);

            str ??= "kek";

            //Test();

            Human man = new Student();
        }



        static void Test(in Student y)
        {

        }
    }

    class Human
    {

    }

    class Student : Human
    {

    }
}
