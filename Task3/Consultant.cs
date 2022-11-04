using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task3
{
    internal class Consultant : Staff
    {       
        /// <summary>
        /// Возвращает имя клиента
        /// </summary>
        /// <param name="client">Объект Client</param>
        /// <returns></returns>
        public virtual string GetClientName(Client client) => client.Name;

        /// <summary>
        /// Возвращает фамилию клиента
        /// </summary>
        /// <param name="client">Объект Client</param>
        /// <returns></returns>
        public virtual string GetClientSurame(Client client) => client.Surname;

        /// <summary>
        /// Возвращает отчество клиента
        /// </summary>
        /// <param name="client">Объект Client</param>
        /// <returns></returns>
        public virtual string GetClientPatronymic(Client client) => client.Patronymic;

        /// <summary>
        /// Возвращает номер телефона клиента
        /// </summary>
        /// <param name="client">Объект Client</param>
        /// <returns></returns>
        public virtual string GetClientPhone(Client client) => client.PhoneNumber;

        /// <summary>
        /// Возвращает паспортные данные клиента 
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public virtual string GetClientPassport(Client client)
        {
            return Regex.Replace(client.Passport, "[0-9]", "*"); 
        }

        /// <summary>
        /// Устанавливает клиенту новоё имя
        /// </summary>
        /// <param name="client">Объект Client</param>
        /// <param name="name">Новое имя</param>
        public virtual void SetClientName(Client client, string name)
        {
            Console.WriteLine("Недостаточно прав");
        }

        /// <summary>
        /// Устанавливает клиенту новую фамилию
        /// </summary>
        /// <param name="client">Объект Client</param>
        /// <param name="surname">Новая фамилия</param>
        public virtual void SetClientSurname(Client client, string surname)
        {
            Console.WriteLine("Недостаточно прав");
        }

        /// <summary>
        /// Устанавливает клиенту новоё отчество
        /// </summary>
        /// <param name="client">Объект Client</param>
        /// <param name="patronymic">Новое отчество</param>
        public virtual void SetClientPatronymic(Client client, string patronymic)
        {
            Console.WriteLine("Недостаточно прав");
        }

        /// <summary>
        /// Устанавливает новый номер телефона клиента
        /// </summary>
        /// <param name="client">Объект Client</param>
        /// <param name="phone">Новый номер телефона</param>
        public virtual void SetClientPhone(Client client, string phone)
        {
            client.PhoneNumber = phone;
        }

        /// <summary>
        /// Устанавливает клиенту новые пасспортные данные
        /// </summary>
        /// <param name="client">Объект Client</param>
        /// <param name="passportSeries">Новая серия паспорта</param>
        /// <param name="passportNumber">Новый номер паспорта</param>
        public virtual void SetClientPassport(Client client, string passportSeries, string passportNumber)
        {
            Console.WriteLine("Недостаточно прав");
        }
    }
}
