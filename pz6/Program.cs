using System;

namespace pz6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            int b = 1;
            while (b < n + 1)
            {
                a = b;
                b = a + b;
            }
            Console.WriteLine(b);
        }
    }
}
