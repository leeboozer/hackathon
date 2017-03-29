using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hackathon.Models;

namespace hackathon.Repositories
{
    public class ClientRepository
    {
        public ClientRepository()
        {
        }

        public List<Client> GetClients()
        {
            var clients = Mercury.db.Client.OrderBy(c => c.AccountName).ToList();
            return clients;
        }
    }
}
