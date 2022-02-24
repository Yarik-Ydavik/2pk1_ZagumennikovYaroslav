using PZ_5_Zagumennikov_Yaroslav;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PZ5_Zagumennikov_Yaroslav
{
    internal class RecoveredPatient : Patient
    {
        public DateTime DateOfDischarge { get; set; }
        public string Result { get; set; }
        public RecoveredPatient (string name, string fam, string otchestvo, string diagnos, DateTime birth, string result, DateTime dateofdischarge) : base(name,fam, otchestvo, diagnos, birth)
        {
            this.Result = result;
            this.DateOfDischarge = dateofdischarge;
        }
        public void GetPatientInfo()
        {
            Console.WriteLine($" Имя: {_name} \n Фамилия: {_fam} \n Отчество: {_otch}\n Дата рождения: {_dataBirth}\n Дата поступления: {datePostup}\n Диагноз: {_diagnos}    \n \nПациент: {Name} закончил лечение в больнице: {DateOfDischarge} с результатом {Result}") ;
        }
    }
}