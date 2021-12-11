using System;
using System.IO;

namespace pz_15_исправленная
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Program Files\texttext\TextFile.txt";
            char[] massChar = new char[] { '/', ',', '.', '?', '!', '~', '`', '@', '"','#','№','$',';',':','<','>','|','(',')' };
            char [] massInt = new char [] { '1','2','3','4','5','6','7','8','9','0' };
            int a = 0;
            int b = 0;
            int c = 0;
            FileInfo fileInf = new FileInfo(path);
            if (fileInf.Exists)
            {
                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                {
                    string lineTest;
                    //цикл ниже будет построчно читать строчки до пустой строки
                    while ((lineTest = sr.ReadLine()) != null)
                    {
                        //цикл ниже считывает длину строки, определяя количество итераций сравнения с массивом символов
                        for (int i=0; i< lineTest.Length; i++)
                        {
                            
                            foreach (int j in massChar)
                            {
                                //условие проверки символа строки на совпадение с значениями из массива
                                //Таким образом разработал свой собственный метод Char.IsDigit  :)
                                if (lineTest[i]== j)
                                {
                                    a++;
                                }
                            }
                            foreach (int l in massInt)
                            {
                                
                                //условие проверки символа строки на совпадение с значениями из массива
                                if (lineTest[i] == l)
                                {
                                    b++;
                                }
                            }
                        }
                        //прибавляет количество символов строки к значению c
                        c += lineTest.Length;
                    }
                }
            }
            //вычесть из общего количества символов, цифры и знаки препинания
            Console.WriteLine("Общее количество символов {0}", c);
            c = c - a - b;
            Console.WriteLine("Количество знаков препинания {0}",a);
            Console.WriteLine("Количество цифр {0}",b);
            Console.WriteLine("Количество букв {0}",c);
        }
    }
}
