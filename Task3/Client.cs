using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public enum lastChangedData { NAME, SURNAME, PATRONYMIC, PHONENUMBER, PASSPORT }
    public enum person { CONSULTANT, MANAGER }

    public class Client
    {
        private string name;
        private string surname;
        private string patronymic;
        private string phoneNumber;
        private string passport;
        public DateTime timeOfChange;
        public lastChangedData changedData;
        public person person;

        /// <summary>
        /// Имя клиента
        /// </summary> 
        public string Name
        {
            get { return name; }
            set 
            {
                if (value != "")
                    name = value;
                else
                    name = "No Data";
                timeOfChange = DateTime.Now;
                changedData = lastChangedData.NAME;
            }
        }

        /// <summary>
        /// Фамилия клиента
        /// </summary>
        public string Surname
        {
            get { return surname; }
            set
            {
                if (value != "")
                    surname = value;
                else
                    surname = "No Data";
                timeOfChange = DateTime.Now;
                changedData = lastChangedData.SURNAME;
            }
        }
        /// <summary>
        /// Отчество клиента
        /// </summary>
        public string Patronymic
        {
            get { return patronymic; }
            set
            {
                if (value != "")
                    patronymic = value;
                else
                    patronymic = "No Data";
                timeOfChange = DateTime.Now;
                changedData = lastChangedData.PATRONYMIC;
            }
        }
        /// <summary>
        /// Имя клиента
        /// </summary>
        public string PhoneNumber 
        {
            get { return phoneNumber; }
            set
            {
                bool result = true;
                foreach (char ch in value)
                {
                    if (!char.IsDigit(ch))
                    {
                        result = false;
                        break;
                    }
                }
                phoneNumber = result ? value : "No Data";
                timeOfChange = DateTime.Now;
                changedData = lastChangedData.PHONENUMBER;
            }
        }
      
        /// <summary>
        /// Имя клиента
        /// </summary>
        public string Passport 
        { 
            get { return passport; }
            set
            {
                if (value.Length == 11)
                    passport = value;
                else
                    passport = "No Da";
                timeOfChange = DateTime.Now;
                changedData = lastChangedData.PASSPORT;
            }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса Client
        /// </summary>
        /// <param name="fullName">Имя</param>
        /// <param name="surname">Фамилия</param>
        /// <param name="patronymic">Отчество</param>
        /// <param name="phoneNumber">Номер телефона</param>
        /// <param name="passportSeries">Серия паспорта</param>
        /// <param name="passportNumber">Номер паспорта</param>
        public Client(string fullName, string surname, string patronymic, string phoneNumber, string passportSeries, string passportNumber)
        {
            Name = fullName;
            Surname = surname;
            Patronymic = patronymic;
            PhoneNumber = phoneNumber;
            Passport = $"{passportSeries} {passportNumber}";
            timeOfChange = DateTime.Now;
        }  
    }
}


