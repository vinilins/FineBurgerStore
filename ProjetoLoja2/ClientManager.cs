using ProjectStore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectStore
{
    public class ClientManager : DataBaseManager
    {
        private static ClientManager _instance;

        public static ClientManager GetInstance()
        {
            if (_instance == null)
            {
                _instance = new ClientManager();
            }
            return _instance;
        }

        public ClientManager()
        {
            //   ClientList = new List<Client>();
            ClientList = FineBurgerContext.Clients.ToList();
        }

        public List<Client> ClientList { get; set; }

        public void AddList(Client newClient)
        {
            FineBurgerContext.Clients.Add(newClient);
            FineBurgerContext.SaveChanges();
            ClientList = FineBurgerContext.Clients.ToList();
        }

        internal void RemoveList(string buttonValue)
        {
            var clientForDelete = ClientList.First(u => u.Email.Equals(buttonValue));
            FineBurgerContext.Clients.Remove(clientForDelete);
            FineBurgerContext.SaveChanges();
            ClientList = FineBurgerContext.Clients.ToList();
        }
    }
}
