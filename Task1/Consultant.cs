using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task1
{
    internal class Consultant
    {       
        public string GetClientName(Client client) => client.Name;
        public string GetClientSurame(Client client) => client.Surname;
        public string GetClientPatronymic(Client client) => client.Patronymic;
        public string GetClientPhone(Client client) => client.PhoneNumber;
        public string GetClientPassport(Client client) => Regex.Replace(client.Passport, "[0-9]", "*");

        public void SetClientPhone(Client client, string phone)
        {
            client.PhoneNumber = client.CheckPhoneNumber(phone) ? phone : "Некоректный номер";            
        }
    }
}
