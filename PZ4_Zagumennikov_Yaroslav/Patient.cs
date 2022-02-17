using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ4_Zagumennikov_Yaroslav
{
    internal class Patient
    {
        public string _name;
        public string _fam;
        public string _otch;
        public DateTime _dataBirth;
        public DateTime _receiptData;
        public string _diagnos;


        static int counterPatient;
        static int counterPatient18;
        public DateTime startDate = new DateTime(1940, 01, 01);
        public DateTime endDate = new DateTime(2022, 01, 01);

        private int age;
        public int Age
        {
            set
            {
                if (value < 1 || value > endDate.Year - startDate.Year)
                {
                    Console.WriteLine($"Возраст должен быть в диапазоне от 1 до 82");
                }
                    
                else
                {
                    age = value;
                }
                    
            }
            get 
            {
                return age;
            }
        }
        private DateTime datePostup;
        public DateTime DatePostup
        {
            set
            {
                if (value < DateTime.Now.AddDays(-7))
                {
                    Console.WriteLine($"Поступил больше недели назад");
                    Console.WriteLine(value);
                    Console.WriteLine(DateTime.Now.AddDays(-7));

                }

                else
                {
                    datePostup = value;
                }

            }
            get
            {
                return datePostup;
            }
        }
        public Patient() { _name = "Неизвестно"; _fam = "Naxui"; _receiptData= DateTime.Now; }
        public void Print()
        {
            Console.WriteLine($" Имя: {_name} \n Фамилия: {_fam} \n Отчество: {_otch}\n Дата рождения: {_dataBirth}\n Дата поступления: {_receiptData}\n Диагноз: {_diagnos}    ");
        }
    }
}
