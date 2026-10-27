using System;
using System.Text;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            int j, minIdx = 0, negCount = 0, secondNegIdx = -1, temp;
            Random rnd = new Random();
            int[] a = new int[20];

            for (j = 0; j < 20; j++)
            {
                a[j] = 50 - rnd.Next(1, 101);
            }

            Console.WriteLine("Вихідний масив:");
            foreach (int x in a)
            {
                Console.Write(" " + x);
            }
            Console.WriteLine("\n");

            for (j = 1; j < 20; j++)
            {
                if (a[j] < a[minIdx])
                {
                    minIdx = j;
                }
            }

            for (j = 0; j < 20; j++)
            {
                if (a[j] < 0)
                {
                    negCount++;
                    if (negCount == 2)
                    {
                        secondNegIdx = j;
                        break;
                    }
                }
            }

            if (secondNegIdx != -1)
            {
                temp = a[minIdx];
                a[minIdx] = a[secondNegIdx];
                a[secondNegIdx] = temp;
            }

            Console.WriteLine("Масив після перестановки:");
            foreach (int x in a)
            {
                Console.Write(" " + x);
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}