using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task2
{
    internal class Consultant
    {
        /// <summary>
        /// Возвращает имя клиента
        /// </summary>
        /// <param name="client">Объект Client</param>
        /// <returns></returns>
        public string GetClientName(Client client) => client.Name;

        /// <summary>
        /// Возвращает фамилию клиента
        /// </summary>
        /// <param name="client">Объект Client</param>
        /// <returns></returns>
        public string GetClientSurame(Client client) => client.Surname;

        /// <summary>
        /// Возвращает отчество клиента
        /// </summary>
        /// <param name="client">Объект Client</param>
        /// <returns></returns>
        public string GetClientPatronymic(Client client) => client.Patronymic;

        /// <summary>
        /// Возвращает номер телефона клиента
        /// </summary>
        /// <param name="client">Объект Client</param>
        /// <returns></returns>
        public string GetClientPhone(Client client) => client.PhoneNumber;

        /// <summary>
        /// Возвращает паспортные данные клиента 
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public string GetClientPassport(Client client)
        {
            if (this.GetType() == typeof(Consultant))
                return Regex.Replace(client.Passport, "[0-9]", "*");
            else
                return client.Passport;
        }

        /// <summary>
        /// Устанавливает новый номер телефона клиента
        /// </summary>
        /// <param name="client">Объект Client</param>
        /// <param name="phone">Новый номер телефона</param>
        public void SetClientPhone(Client client, string phone)
        {
            client.PhoneNumber = phone;
        }
    }
}
