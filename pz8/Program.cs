using System;

namespace pz8
{
    class Program
    {
        static void Main(string[] args)
        {
            Random RND = new Random();
            int[] a = new int[10];
            for (int i = 0; i <= 9; i++)
            {
                a[i] = RND.Next(0, 4);
            }
            for (int b = 1; b <= 8; b++)
            {
                if (a[b] == a[b + 1] || a[b] == a[b - 1])
                {
                    Console.WriteLine("номер элемента в массиве, который равен соседнему: {0} ", b);
                }
            }
        }
    }
}
