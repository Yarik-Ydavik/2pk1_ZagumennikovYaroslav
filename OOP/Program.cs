using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = Console.ReadLine();
            string Fam = Console.ReadLine();
            string Otch = Console.ReadLine();
            string Diagnos = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Дата рождения");
            Console.WriteLine("");
            Console.WriteLine("Год");
            int Year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Месяц");
            int Month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("День");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("");
            DateTime dateBirthday = new DateTime(Year,Month,day);
            Patient patient = new Patient ( Name,Fam,Otch,Diagnos );
            patient.Print();
            
        }
    }
}
