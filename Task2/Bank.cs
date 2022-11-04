using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Bank
    {
        /// <summary>
        /// Название банка
        /// </summary>
        public string Name { get; private set; }        

        /// <summary>
        /// Контейнер, содержащий экземпляры класса Client
        /// </summary>
        private List<Client> clients;

        /// <summary>
        /// Инициализирует новый экземпляр класса Bank
        /// </summary>
        /// <param name="name">Название</param>
        public Bank(string name)
        {
            Name = name;            
            clients = new List<Client>();
        }

        /// <summary>
        /// Добавление нового клиента 
        /// </summary>
        /// <param name="client">Объект класса Сlient</param>
        public void RegisterNewClient(Client client) => clients.Add(client);
    }
}
