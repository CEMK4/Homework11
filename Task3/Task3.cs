using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Task3
    {
        static void Main(string[] args)
        {
            Client client = new Client("Иван", "Иванов", "Иванович", "88005553535", "1234", "556677");
            Staff staff;            
            Console.WriteLine("Выберите работника:\n" +
                "0 - Консультант; 1 - Менеджер");
            byte key;
            byte.TryParse(Console.ReadLine(), out key);            
            if (key == 1)
                staff = new Manager();
            else if (key == 0)
                staff = new Consultant();
            else
                throw new Exception("Неверный код работника");            
            while (true)
            {
                Console.WriteLine("\nВыберите операцию:\n"
                    + "0 - Вывести имя\n" +
                    "1 - Вывести фамилию\n" +
                    "2 - Вывести отчество\n" +
                    "3 - Вывести телефон\n" +
                    "4 - Вывести паспорт\n" +
                    "5 - Изменить имя\n" +
                    "6 - Изменить фамилию\n" +
                    "7 - Изменить отчество\n" +
                    "8 - Изменить телефон\n" +
                    "9 - Изменить паспорт\n" +
                    "10 - Закончить работу\n");
                int op;
                int.TryParse(Console.ReadLine(), out op);
                if (op == 10) break;
                switch (op)
                {
                    case 0: 
                        Console.WriteLine($"Имя - {staff.GetClientName(client)}");
                        break;
                    case 1: 
                        Console.WriteLine($"Фамилия - {staff.GetClientSurame(client)}");
                        break;
                    case 2: 
                        Console.WriteLine($"Отчество - {staff.GetClientPatronymic(client)}");
                        break;
                    case 3: 
                        Console.WriteLine($"Телефон - {staff.GetClientPhone(client)}");
                        break;
                    case 4: 
                        Console.WriteLine($"Паспорт - {staff.GetClientPassport(client)}");
                        break;
                    case 5: 
                        Console.WriteLine("Введите новое имя");
                        staff.SetClientName(client, Console.ReadLine());
                        break;
                    case 6:
                        Console.WriteLine("Введите новую фамилию");
                        staff.SetClientSurname(client, Console.ReadLine());
                        break;
                    case 7:
                        Console.WriteLine("Введите новое отчество");
                        staff.SetClientPatronymic(client, Console.ReadLine());
                        break;
                    case 8:
                        Console.WriteLine("Введите новый номер телефона");
                        staff.SetClientPhone(client, Console.ReadLine());
                        break;
                    case 9:
                        Console.WriteLine("Введите новую серию паспорта");
                        string serial = Console.ReadLine();
                        Console.WriteLine("Введите новый номер паспорта");
                        string number = Console.ReadLine();
                        staff.SetClientPassport(client, serial, number);
                        break;     
                }
            }
        }
    }
}
