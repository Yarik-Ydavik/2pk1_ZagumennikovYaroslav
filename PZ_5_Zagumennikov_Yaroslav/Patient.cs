using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_5_Zagumennikov_Yaroslav
{
    internal class Patient
    {
        private string _name;
        private string _fam;
        private string _otch;
        public DateTime _dataBirth;
        private DateTime datePostup;
        private string _diagnos;
        public DateTime startDate = new DateTime(1940, 01, 01);
        public DateTime endDate = new DateTime(2022, 01, 01);

        private int age;
        public int Age
        {
            set
            {
                if (value < 1 || value > endDate.Year - startDate.Year)
                {
                    Console.WriteLine($"\n Возраст должен быть в диапазоне от 1 до 82");
                }

                else
                {
                    age = value;
                    if (value < 18) counterPatient18++;
                }

            }
            get
            {
                return age;
            }
        }
        static int counterPatient;
        static int counterPatient18;
        public DateTime DatePostup
        {
            set
            {
                if (value < DateTime.Now.AddDays(-1))
                {
                    if (value < DateTime.Now.AddDays(-7))
                    {
                        Console.WriteLine($"\n Поступил больше недели назад");
                        datePostup = value;
                    }
                    else if (value > DateTime.Now.AddDays(-2))
                    {
                        counterPatient++;
                        datePostup = value;
                    }
                    datePostup = value;

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
        public String Name
        {
            set
            {
                if (value == "")
                {
                    _name = "Значение отсутствует";
                }

                else
                {
                    _name = value;
                }

            }
            get
            {
                return _name;
            }
        }
        public String Family
        {
            set
            {
                if (value == "")
                {
                    _fam = "Значение отсутствует";
                }

                else
                {
                    _fam = value;
                }

            }
            get
            {
                return _fam;
            }
        }
        public String Otch
        {
            set
            {
                if (value == "")
                {
                    _otch = "Значение отсутствует";
                }

                else
                {
                    _otch = value;
                }

            }
            get
            {
                return _otch;
            }
        }
        public String Diagnos
        {
            set
            {
                if (value == "")
                {
                    _diagnos = "Значение отсутствует";
                }

                else
                {
                    _diagnos = value;
                }

            }
            get
            {
                return _diagnos;
            }
        }
        public Patient(string name, string family, string otchestvo, string diagnos, DateTime birth)
        {
            Name = name;
            Family = family;
            Otch = otchestvo;
            Diagnos = diagnos;
            _dataBirth = birth;

        }
        public static void PrintStaticValue()
        {
            Console.WriteLine($" Количество пациентов, которые поступили вчера: {counterPatient}");
            Console.WriteLine($" Количество несовершеннолетних пациентов: {counterPatient18}");
        }
        public void Print()
        {
            Console.WriteLine($" Имя: {_name} \n Фамилия: {_fam} \n Отчество: {_otch}\n Дата рождения: {_dataBirth}\n Дата поступления: {datePostup}\n Диагноз: {_diagnos}    ");
        }
    }
}
