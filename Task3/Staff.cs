using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task3
{
    internal interface Staff
    {        
        string GetClientName(Client client);
        
        string GetClientSurame(Client client);

        string GetClientPatronymic(Client client);

        string GetClientPhone(Client client);

        string GetClientPassport(Client client);

        void SetClientName(Client client, string name);

        void SetClientSurname(Client client, string surname);

        void SetClientPatronymic(Client client, string patronymic);

        void SetClientPhone(Client client, string phone);

        void SetClientPassport(Client client, string passportSeries, string passportNumber);
    }
}
