using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Task2
    {
        static void Main(string[] args)
        {
            Client client = new Client("Иван", "Иванов", "Иванович", "88005553535", "1234", "556677");            
            Manager manager = new Manager();

            Console.WriteLine($"Имя - {manager.GetClientName(client)}");
            Console.WriteLine($"Фамилия - {manager.GetClientSurame(client)}");
            Console.WriteLine($"Отчество - {manager.GetClientPatronymic(client)}");
            Console.WriteLine($"Паспорт - {manager.GetClientPassport(client)}");
            Console.WriteLine($"Номер телефона - {manager.GetClientPhone(client)}\n");

            manager.SetClientName(client, "Пётр");
            Console.WriteLine($"Новое имя - {manager.GetClientName(client)}");
            manager.SetClientSurname(client, "Петров");
            Console.WriteLine($"Новоя фамилия - {manager.GetClientSurame(client)}");
            manager.SetClientPatronymic(client, "Петрович");
            Console.WriteLine($"Новое отчество - {manager.GetClientPatronymic(client)}");            
            manager.SetClientPassport(client, "4321", "123456");
            Console.WriteLine($"Новые паспортные данные - {manager.GetClientPassport(client)}");
            manager.SetClientPhone(client, "89589002345");
            Console.WriteLine($"Новый номер телефона - {manager.GetClientPhone(client)}");
        }
    }
}
