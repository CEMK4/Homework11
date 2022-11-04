using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Manager : Consultant
    {
        /// <summary>
        /// Устанавливает клиенту новоё имя
        /// </summary>
        /// <param name="client">Объект Client</param>
        /// <param name="name">Новое имя</param>
        public void SetClientName(Client client, string name)
        {
            client.Name = name;
        }

        /// <summary>
        /// Устанавливает клиенту новую фамилию
        /// </summary>
        /// <param name="client">Объект Client</param>
        /// <param name="surname">Новая фамилия</param>
        public void SetClientSurname(Client client, string surname)
        {
            client.Surname = surname;
        }

        /// <summary>
        /// Устанавливает клиенту новоё отчество
        /// </summary>
        /// <param name="client">Объект Client</param>
        /// <param name="patronymic">Новое отчество</param>
        public void SetClientPatronymic(Client client, string patronymic)
        {
            client.Patronymic = patronymic;
        }

        /// <summary>
        /// Устанавливает клиенту новые пасспортные данные
        /// </summary>
        /// <param name="client">Объект Client</param>
        /// <param name="passportSeries">Новая серия паспорта</param>
        /// <param name="passportNumber">Новый номер паспорта</param>
        public void SetClientPassport(Client client, string passportSeries, string passportNumber)
        {
            client.Passport = $"{passportSeries} {passportNumber}";
        }
    }
}
