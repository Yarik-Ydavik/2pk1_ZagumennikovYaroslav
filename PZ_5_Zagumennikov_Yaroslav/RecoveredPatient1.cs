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
        public RecoveredPatient (string result, DateTime dateofdischarge, string _name) : base(_name)
        {
            this.Result = result;
            this.DateOfDischarge = dateofdischarge;
        }
        public void GetPatientInfo()
        {
            Console.WriteLine($"Пациент: {Name} закончил лечение в больнице: {DateOfDischarge} с результатом {Result}") ;
        }
    }
}