using System;

namespace PZ3_FedorovSemyon
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Номер карты");
            string Number = Console.ReadLine();
            int NumbeR = 0;
            if (Number == "")
            {
                NumbeR = 0;
            }
            else
            {
                NumbeR = Convert.ToInt32(Number);
            }

            Console.WriteLine("Срок действия");
            string Validity = Console.ReadLine();
            int ValiditY = 0;
            if (Validity == "")
            {
                ValiditY = 0;
            }
            else
            {
                ValiditY = Convert.ToInt32(Validity);
            }
            Console.WriteLine("Код безопасности");
            string code = Console.ReadLine();
            int Code = 0;
            if (code == "")
            {
                Code = 0;
            }
            else
            {
                Code = Convert.ToInt32(code);
            }
            Console.WriteLine("ФИО клиента");
            string FIO = Console.ReadLine();
            Console.WriteLine("Тип карты: Дебетовая/кредитная");
            string type = Console.ReadLine();
            Card card1 = new Card();
            card1.Print();
            Console.WriteLine("");
            Card card2 = new Card(NumbeR, FIO, ValiditY, Code, type);
            card2.Print();
            Console.WriteLine("");
            Card card3 = new Card(NumbeR, ValiditY, Code);
            card3.Print();
            Console.WriteLine("");
            Card card4 = new Card(FIO, type);
            card4.Print();
            Console.WriteLine("");
        }
    }
}
