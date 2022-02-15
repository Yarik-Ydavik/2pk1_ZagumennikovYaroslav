using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Patient
    {
        public string _name;
        public string _fam ;
        public string _otch ;
        public DateTime _dataBirth = new DateTime(1999, 7, 20, 18, 30, 25);
        public DateTime _receiptData = DateTime.Now;
        public string _diagnos;
        public Patient()
        {
                  
        }
        public Patient(string fam= "sadsads", string name ="", string otch= "", string diagnos="")
        {
            _fam = fam;
            _otch = otch;
            _name = name;
            _diagnos = diagnos;
        }
        public Patient(string fam, string name, string otch, string diagnos,DateTime dataBirth, DateTime receiptData)
        {
            _fam = fam;
            _otch = otch;
            _name = name;
            _diagnos = diagnos;
            _dataBirth= dataBirth;
            _receiptData = receiptData;
    }
        public Patient( DateTime dataBirth, DateTime receiptData)
        {
            
            _dataBirth = dataBirth;
            _receiptData = receiptData;
        }
        public void Print()
        {
            Console.WriteLine($" Имя: {_name} \n Фамилия: {_fam} \n Отчество: {_otch}\n Дата рождения: {_dataBirth}\n Дата поступления: {_receiptData}\n Диагноз: {_diagnos}");
        }

    }
}
