using System;


namespace PZ_4_Zagumennikov_Yaroslav
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Имя");
            string Name = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Фамилия");
            string Fam = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Отчество");
            string Otch = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Диагноз");
            string Diagnos = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Дата рождения");
            Console.WriteLine("");
            Console.WriteLine("Год");
            string Year = Console.ReadLine();
            int YeaR = 1;
            if (Year == "")
            {
                YeaR = 2000;
            }
            else
            {
                YeaR = Convert.ToInt32(Year);
            }

            Console.WriteLine("Месяц");
            string Month = Console.ReadLine();
            int MontH = 1;
            if (Month == "")
            {
                MontH = 2;
            }
            else
            {
                MontH = Convert.ToInt32(Month);
            }
            Console.WriteLine("День");
            string day = Console.ReadLine();
            int Day = 1;
            if (day == "")
            {
                Day = 2;
            }
            else
            {
                Day = Convert.ToInt32(day);
            }
            var date = new DateOnly(2020, 04, 20);
            DateOnly now = DateOnly.Parse("06.01.2022");

            Console.WriteLine("");
            Console.WriteLine("");
            DateTime dateBirthday = new DateTime(YeaR, MontH, Day);
            DateTime receiptData = DateTime.Now;
            Patient patient = new Patient();
            patient.Print();
            Console.WriteLine("");
            Patient patient2 = new Patient(Name, Fam, Otch, Diagnos);
            patient2.Print();
            Console.WriteLine("");
            Patient patient3 = new Patient(dateBirthday, receiptData);
            patient3.Print();
            Console.WriteLine("");
            Patient patient4 = new Patient(Name, Fam, Otch, Diagnos, dateBirthday, receiptData);
            patient4.Print();
        }
    }
}
