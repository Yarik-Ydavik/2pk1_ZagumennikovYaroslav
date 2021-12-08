using System;

namespace pz_18
{
    class Program
    {
        /*
        static public double Arifmetical(double a1, double d, int n)
        {
            if (n == 1)
                return 1;
            return a1 + Arifmetical(a1, d, n-1)*d;
        }
        static void Main(string[] args)
        {
            double a1 = 0;
            double d1 = -0.3;
            Console.Write("Искомый член (n)");
            int n1 = Convert.ToInt32(Console.ReadLine());
            double arif = Arifmetical(a1, d1, n1);
            Console.WriteLine(arif);
        }
        
        













        static public double Geometrical(double a1, double q, int n)
        {
            

            if (n == 0)
                return 1;

            return a1 * Math.Pow(q,Geometrical(a1, q, n-1));

            
        }
        static void Main(string[] args)
        {
            double b1 = 6;
            double q = 0.2;
            int n = Convert.ToInt32(Console.ReadLine());
            double geometry = Geometrical(b1, q, n);
            Console.WriteLine(geometry);
        }
        









        static public int Rekursia(int A, int B)
        {
            if (A == B) 
            { 
                Console.WriteLine(A); return 0; 
            }
            else 
            {
                if (B<A)
                {
                    Console.Write(A);
                    A -= 1;
                    if (A == B || A < B)
                    {
                        return B;
                    }
                }
                else
                {
                    Console.Write(A);
                    A += 1;
                    if (A == B || A > B)
                    {
                        return A;
                    }
                }
                
            }
            return Rekursia(A, B);

        }
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int Rekursia1 = Rekursia(a, b);
            Console.WriteLine(Rekursia1);
        }
        */









        //4задание 

        static public string Rekursia(int A)
        {
            string str = A.ToString();
            if (str.Length > 1)
                return str[str.Length - 1] + Rekursia(Convert.ToInt32(str.Remove(str.Length - 1)));
            else
                return A.ToString();

        }
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            string Rekursia1 = Rekursia(a);
            Console.WriteLine(Rekursia1);
        }

    }
}
