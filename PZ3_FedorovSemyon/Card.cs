using System;
using System.Collections.Generic;
using System.Text;

namespace PZ3_FedorovSemyon
{
    class Card
    {
        public int _number;
        public string _clientFIO;
        public int _validity;
        public int _secureCode;
        public string _type;
        public Card(int number, string clientFIO, int validity, int secureCode, string type)
        {
            _number = number;

            _clientFIO = clientFIO;

            _validity = validity;

            _secureCode = secureCode;

            _type = type;

        }
        public Card()
        {
            _number = 0;

            _clientFIO = "Отсутствует";

            _validity = 0;

            _secureCode = 0;

            _type = "Отсутствует";

        }
        public Card(int number, int validity, int secureCode)
        {
            _number = number;

            _clientFIO = "Данные отсутствуют";

            _validity = validity;

            _secureCode = secureCode;

            _type = "Данные отсутствуют";

        }
        public Card(string clientFIO, string type)
        {
            _number = 0;

            _clientFIO = clientFIO;

            _validity = 0;

            _secureCode = 0;

            _type = type;

        }

        public void Print()
        {
            Console.WriteLine($" Номер карты: {_number}\n Фио клиента: {_clientFIO}\n Срок действия: {_validity}\n Код безопасности: {_secureCode}\n Дебетовая/кредитная:{_type}");
        }
    }
}
