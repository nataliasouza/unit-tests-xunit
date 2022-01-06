using System.Collections.Generic;

namespace Feature.Clients
{
    public interface IClientService
    {
        public IEnumerable<Client> GetAllActive();
        public void AddClient(Client client);
    }
}
