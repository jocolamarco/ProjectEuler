using System;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Problem1: "+ Problem1());
        }

        static int Problem1()
        {
            int multipleA = 3;
            int multipleB = 5;
            int belowValue = 10;
            int sum_of_multiples = 0;

            for (int i = 1; i <= belowValue; i++)
            {
                if ((i%multipleA == 0) || (i%multipleB == 0))
                {
                    sum_of_multiples += i;
                }

            }


            return sum_of_multiples;
        }
    }
}
