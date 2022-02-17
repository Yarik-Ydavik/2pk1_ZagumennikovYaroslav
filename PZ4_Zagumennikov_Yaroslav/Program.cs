using System;

namespace PZ4_Zagumennikov_Yaroslav
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime ourTime= DateTime.Now;
            string OurTime = Convert.ToString(ourTime);
            Console.WriteLine("Имя\n");
            string Name = Console.ReadLine();
            Console.WriteLine("Фамилия\n");
            string Fam = Console.ReadLine();
            Console.WriteLine("Отчество\n");
            string Otch = Console.ReadLine();
            Console.WriteLine("Диагноз\n");
            string Diagnos = Console.ReadLine();
            Console.WriteLine("Дата рождения");
            string a = Console.ReadLine();
            DateTime dateBirthday = DateTime.Parse(a == "" ? "01.01.1990": a) ;
            Console.WriteLine("Дата поступления");
            string datePostuplenya = Console.ReadLine();
            DateTime receiptData = DateTime.Parse(datePostuplenya == "" ? OurTime : datePostuplenya);
            
            int ag = DateTime.Now.Year - dateBirthday.Year;
            Patient patient = new Patient() ;

            patient.Age = ag;
            Console.WriteLine(patient.Age);

            patient.DatePostup = receiptData;
            Console.WriteLine(patient.DatePostup);

            Patient patient1 = new Patient() ;
            patient1.Print();
        }
    }
}

