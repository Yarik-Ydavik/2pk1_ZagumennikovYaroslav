using System;

namespace pz5
{
    class Program
    {
        static void Main(string[] args)
        {
            Zadanye_1 zadanye_1 = new Zadanye_1();
            Zadanye_2 zadanye_2 = new Zadanye_2();
            Zadanye_3 zadanye_3 = new Zadanye_3();
            Zadanye_4 zadanye_4 = new Zadanye_4();
            Zadanye_5 zadanye_5 = new Zadanye_5();
            zadanye_2.Result();
            //сменить имя класса, на конкретное задание - zadanye_4.Result(), zadanye_3.Result(),zadanye_2.Result()
        }
    }
    class Zadanye_1
    {

        public void Result()
        {
            for (int a = 20; a <= 100; a += 4)
            {
                Console.WriteLine(a);
            }
        }
    }
    class Zadanye_2
    {
        public void Result()
        {
            string[] b = { "/", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", };
            int c = Convert.ToInt32(Console.ReadLine());
            //вводим номер варианта студента 
            int g = c + 7;
            for (int d = c; c < g; c += 1)
            {
                Console.Write(b[c]);
            }
        }
    }
    class Zadanye_3
    {
        public void Result()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            //номер варианта студента
            for (int a = 0; a < n; a += 1)
            {
                for (int b = 0; b < 4; b += 1)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
    class Zadanye_4
    {
        public void Result()
        {
            for (int a = 0; a < 100; a += 1)
            {
                if (a % 11 == 0)
                {
                    Console.WriteLine(a);
                }
            }
        }
    }
    class Zadanye_5
    {
        public void Result()
        {
            for (int a = 2, b = 40; b - a > 19; a++, b--)
            {
                Console.WriteLine("i и j = " + a + " и " + b);
            }
        }
    }
}
