using System;
using System.Linq;
using System.IO;
namespace pz__15
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Program Files\texttext\TextFile.txt";
            int b = 0;
            int a = 0;
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    b++;
                    a = a + line.Length;
                    Console.WriteLine(line);

                }
                int count = File.ReadAllText(@"D:\Program Files\texttext\TextFile.txt").Where(char.IsDigit).Count();
                int count1 = File.ReadAllText(@"D:\Program Files\texttext\TextFile.txt").Where(char.IsLetter).Count();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Количество цифр: " + count);
                Console.WriteLine("Количество символов: " + a);
                Console.WriteLine("Количество букв: " + count1);
                sr.Close();
                Console.ReadLine();
            }
        }
    }
}
