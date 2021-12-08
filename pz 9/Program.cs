using System;

namespace pz_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Random RND = new Random();
            int[,] a = new int[3, 4];
            for (int i = 0; i < 3; i += 1)
            {
                for (int b = 0; b < 4; b += 1)
                {
                    a[i, b] = RND.Next(0, 199);
                }
            }
            int f = 0;
            for (int i = 0; i < 3; i += 1)
            {
                for (int b = 0; b < 4; b += 1)
                {

                    int summ = 0;
                    for (int i1 = 0; i1 < Convert.ToString(a[i, b]).Length; i1++)
                    {
                        if (char.IsNumber(Convert.ToString(a[i, b])[i1]))
                        {

                            summ += Convert.ToInt32(Convert.ToString(a[i, b])[i1].ToString());
                        }
                    }

                    if (summ % 2 == 0)
                    {
                        f += 1;


                    }

                }
            }
            Console.WriteLine(f);
        }
    }
}
