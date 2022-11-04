using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task3
{
    internal class Manager : Consultant
    {
        /// <summary>
        /// Возвращает паспортные данные клиента 
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public override string GetClientPassport(Client client)
        {
            return client.Passport;
        }

        /// <summary>
        /// Устанавливает клиенту новоё имя
        /// </summary>
        /// <param name="client">Объект Client</param>
        /// <param name="name">Новое имя</param>
        public override void SetClientName(Client client, string name)
        {
            client.Name = name;
        }

        /// <summary>
        /// Устанавливает клиенту новую фамилию
        /// </summary>
        /// <param name="client">Объект Client</param>
        /// <param name="surname">Новая фамилия</param>
        public override void SetClientSurname(Client client, string surname)
        {
            client.Surname = surname;
        }

        /// <summary>
        /// Устанавливает клиенту новоё отчество
        /// </summary>
        /// <param name="client">Объект Client</param>
        /// <param name="patronymic">Новое отчество</param>
        public override void SetClientPatronymic(Client client, string patronymic)
        {
            client.Patronymic = patronymic;
        }

        /// <summary>
        /// Устанавливает клиенту новые пасспортные данные
        /// </summary>
        /// <param name="client">Объект Client</param>
        /// <param name="passportSeries">Новая серия паспорта</param>
        /// <param name="passportNumber">Новый номер паспорта</param>
        public override void SetClientPassport(Client client, string passportSeries, string passportNumber)
        {
            client.Passport = $"{passportSeries} {passportNumber}"; ;
        }
    }
}
