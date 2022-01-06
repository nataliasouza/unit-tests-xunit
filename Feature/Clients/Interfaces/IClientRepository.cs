using Feature.Core;

namespace Feature.Clients
{
    public interface IClientRepository : IRepository<Client>
    {
        Client GetByEmail(string email);
    }
}
