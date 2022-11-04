using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Task1
    {
        static void Main(string[] args)
        {
            Client client = new Client("Иван", "Иванов", "Иванович", "88005553535",1234,556677);
            Consultant consultant = new Consultant();

            Console.WriteLine($"Имя - {consultant.GetClientName(client)}");
            Console.WriteLine($"Фамилия - {consultant.GetClientSurame(client)}");
            Console.WriteLine($"Отчество - {consultant.GetClientPatronymic(client)}");
            Console.WriteLine($"Паспорт - {consultant.GetClientPassport(client)}");
            Console.WriteLine($"Номер телефона - {consultant.GetClientPhone(client)}");

            consultant.SetClientPhone(client, "89589002345");
            Console.WriteLine($"После изменения номера телефона - {consultant.GetClientPhone(client)}");
        }
    }
}
