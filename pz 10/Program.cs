using System;

namespace pz_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = { "mouse", "cat", "child rat", "batting", "dogger", "I", "Steave Hophikns", "on", "children school primary", "institut imeni Presidenta Trampa", "BOY", "girl", "history", "science", "computer games", "player", "guse", "cow", "pistol" };
            string[][] massive = new string[5][];
            string[] massive2 = new string[5];
            string[] massive3 = new string[5];
            int n = 0;
            Random rnd = new Random();
            Random Rnd = new Random();
            Console.WriteLine("Ступенчатый массив:");
            for (int i = 0; i < 5; i++)
            {
                massive[i] = new string[rnd.Next(3, 20)];
                for (int y = 0; y < massive[i].Length; y++)
                {
                    massive[i][y] = a[new Random().Next(0, a.Length)];
                }


                for (int c = 0; c < massive[i].Length; c++)
                {
                    Console.Write($"{massive[i][c]}" + ", ");
                    string s = massive[i][c];
                    char[] array = s.ToCharArray();

                    if (c == massive[i].Length - 1)
                    {
                        Console.WriteLine();
                        massive2[n] = massive[i][c];
                        n++;
                    }
                }
                Console.WriteLine();


            }
            int[] chislo_massive = new int[massive[0].Length];
            for (int i = 0; i < 1; i++)
            {
                for (int c1 = 0; c1 < massive[i].Length; c1++)
                {
                    string s = massive[i][c1];
                    chislo_massive[c1] = s.Length;



                }
            }
            int max = -1;
            int index = -1;
            // Цикл по всем элементам массива
            // От 0 до размера массива
            for (int i = 0; i < chislo_massive.Length; i++)

                if (max <= chislo_massive[i])
                {
                    // Запоминаем новое максимальное значение
                    max = chislo_massive[i];
                    // Запоминаем порядковый номер
                    index = i;
                }
            int[] chislo_massive1 = new int[massive[1].Length];
            for (int i = 1; i < 2; i++)
            {
                for (int c1 = 0; c1 < massive[i].Length; c1++)
                {
                    string s = massive[i][c1];
                    chislo_massive1[c1] = s.Length;



                }
            }
            int max1 = -1;
            int index1 = -1;
            // Цикл по всем элементам массива
            // От 0 до размера массива
            for (int i = 0; i < chislo_massive1.Length; i++)

                if (max1 <= chislo_massive1[i])
                {
                    // Запоминаем новое максимальное значение
                    max1 = chislo_massive1[i];
                    // Запоминаем порядковый номер
                    index1 = i;
                }
            int[] chislo_massive2 = new int[massive[2].Length];
            for (int i = 2; i < 3; i++)
            {
                for (int c1 = 0; c1 < massive[i].Length; c1++)
                {
                    string s = massive[i][c1];
                    chislo_massive2[c1] = s.Length;



                }
            }
            int max2 = -1;
            int index2 = -1;
            // Цикл по всем элементам массива
            // От 0 до размера массива
            for (int i = 0; i < chislo_massive2.Length; i++)

                if (max2 <= chislo_massive2[i])
                {
                    // Запоминаем новое максимальное значение
                    max2 = chislo_massive2[i];
                    // Запоминаем порядковый номер
                    index2 = i;
                }
            int[] chislo_massive3 = new int[massive[3].Length];
            for (int i = 3; i < 4; i++)
            {
                for (int c1 = 0; c1 < massive[i].Length; c1++)
                {
                    string s = massive[i][c1];
                    chislo_massive3[c1] = s.Length;



                }
            }
            int max3 = -1;
            int index3 = -1;
            // Цикл по всем элементам массива
            // От 0 до размера массива
            for (int i = 0; i < chislo_massive3.Length; i++)

                if (max3 <= chislo_massive3[i])
                {
                    // Запоминаем новое максимальное значение
                    max3 = chislo_massive3[i];
                    // Запоминаем порядковый номер
                    index3 = i;
                }
            int[] chislo_massive4 = new int[massive[4].Length];
            for (int i = 4; i < 5; i++)
            {
                for (int c1 = 0; c1 < massive[i].Length; c1++)
                {
                    string s = massive[i][c1];
                    chislo_massive4[c1] = s.Length;



                }
            }
            int max4 = -1;
            int index4 = -1;
            // Цикл по всем элементам массива
            // От 0 до размера массива
            for (int i = 0; i < chislo_massive4.Length; i++)

                if (max4 <= chislo_massive4[i])
                {
                    // Запоминаем новое максимальное значение
                    max4 = chislo_massive4[i];
                    // Запоминаем порядковый номер
                    index4 = i;
                }
            int[] massive_max_clov = new int[5];
            massive_max_clov[0] = index;
            massive_max_clov[1] = index1;
            massive_max_clov[2] = index2;
            massive_max_clov[3] = index3;
            massive_max_clov[4] = index4;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Массив максимальных элементов: ");
            Console.WriteLine();
            Console.WriteLine(massive[0][massive_max_clov[0]] + "," + massive[1][massive_max_clov[1]] + "," + massive[2][massive_max_clov[2]] + "," + massive[3][massive_max_clov[3]] + "," + massive[4][massive_max_clov[4]]);
            Console.WriteLine();
            Console.WriteLine("Массив последних элементов: ");
            for (int u = 0; u < massive2.Length; u++)
            {
                Console.Write($"{massive2[u]}" + ", ");
            }
            Console.WriteLine();
        }
    }
}
