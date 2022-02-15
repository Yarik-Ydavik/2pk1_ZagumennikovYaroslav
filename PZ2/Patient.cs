using System;
using System.Collections.Generic;
using System.Text;

namespace PZ2
{
    class Patient
    {
        
        public string _name;
        public string _fam;
        public string _otch;
        public DateTime _dataBirth;
        public DateTime _receiptData;
        public string _diagnos;
        public Patient()
        {
            _name = "Отсутствует";
            
            _fam = "Отсутствует";
            
            _otch = "Отсутствует";
            
            _dataBirth = new DateTime();
            
            _receiptData = new DateTime();
            
            _diagnos = "Отсутствует";
    }
        public Patient(string name, string fam , string otch , string diagnos )
        {
            _name = name;

            _fam = fam;

            _otch = otch;

            _dataBirth = new DateTime();

            _receiptData = new DateTime();

            _diagnos = diagnos;

        }
        public Patient(string name, string fam , string otch , string diagnos , DateTime dataBirth , DateTime receiptData)
        {
            _fam = fam;
            _otch = otch;
            _name = name;
            _diagnos = diagnos;
            _dataBirth = dataBirth;
            _receiptData = receiptData;
        }
        public Patient(DateTime dataBirth, DateTime receiptData)
        {

            _name = "Отсутствует";

            _fam = "Отсутствует";

            _otch = "Отсутствует";

            _diagnos = "Отсутствует";
            _dataBirth = dataBirth;
            _receiptData = receiptData;
        }
        public void Print()
        {
            Console.WriteLine($" Имя: {_name} \n Фамилия: {_fam} \n Отчество: {_otch}\n Дата рождения: {_dataBirth}\n Дата поступления: {_receiptData}\n Диагноз: {_diagnos}");
        }
    }
}
