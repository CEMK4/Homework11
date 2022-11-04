using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Client
    {
        /// <summary>
        /// Имя клиента
        /// </summary> 
        public string Name { get; private set; }

        /// <summary>
        /// Фамилия клиента
        /// </summary>
        public string Surname { get; private set; }

        /// <summary>
        /// Отчество клиента
        /// </summary>
        public string Patronymic { get; private set; }

        /// <summary>
        /// Имя клиента
        /// </summary>
        public string PhoneNumber { get; set; }
      
        /// <summary>
        /// Имя клиента
        /// </summary>
        public string Passport { get; private set; }

        /// <summary>
        /// Инициализирует новый экземпляр класса Client
        /// </summary>
        /// <param name="fullName">Имя</param>
        /// <param name="surname">Фамилия</param>
        /// <param name="patronymic">Отчество</param>
        /// <param name="phoneNumber">Номер телефона</param>
        /// <param name="passportSeries">Серия паспорта</param>
        /// <param name="passportNumber">Номер паспорта</param>
        public Client(string fullName, string surname, string patronymic, string phoneNumber, uint passportSeries, uint passportNumber)
        {
            Name = fullName;
            Surname = surname;
            Patronymic = patronymic;
            PhoneNumber = CheckPhoneNumber(phoneNumber) ? phoneNumber : "Некоректный номер";
            Passport = $"{passportSeries} {passportNumber}";
        }  
        
        public bool CheckPhoneNumber(string phoneNumber)
        {
            bool result = true;
            foreach (char ch in phoneNumber)
            {
                if (!char.IsDigit(ch))
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
    }
}


