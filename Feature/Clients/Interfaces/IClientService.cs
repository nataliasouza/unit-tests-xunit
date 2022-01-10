using System.Collections.Generic;

namespace Feature.Clients
{
    public interface IClientService
    {
        public IEnumerable<Client> GetAllActive();
        public void AddClient(Client client);
        public void Update(Client client);
        public void Inactivate(Client client);
        public void Delete(Client client);
    }
}
