using MediatR;
using System.Collections.Generic;
using System.Linq;

namespace Feature.Clients
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;
        private readonly IMediator _mediator;

        public ClientService(IClientRepository clientRepository, IMediator mediator)
        {
            _clientRepository = clientRepository;
            _mediator = mediator;
        }

        public IEnumerable<Client> GetAllActive()
        {
            return _clientRepository.GetAll().Where(c => c.Active);
        }

        public void AddClient(Client client)
        {
            if (!client.IsValid())
                return;
            _clientRepository.Add(client);
            _mediator.Publish(new ClientEmailNotification("contato@empresa.com", client.Email, "Olá!", "Bem vindo(a)!"));
        }

        public void Update(Client client)
        {
            if(!client.IsValid())
                    return;
            _clientRepository.Update(client);
            _mediator.Publish(new ClientEmailNotification("contato@empresa.com", client.Email, "Atualizações", "Veja as mudanças!"));
        }

        public void Inactivate(Client client)
        {
            if (!client.IsValid())
                return;

            client.Inactivate();
            _clientRepository.Update(client);
            _mediator.Publish(new ClientEmailNotification("contato@empresa.com", client.Email, "Até mais", "Volte quando quiser!"));
        }
        public void Delete(Client client)
        {
            _clientRepository.Delete(client.Id);
            _mediator.Publish(new ClientEmailNotification("contato@empresa.com", client.Email, "Removido!", "Até mais!"));
        }
        public void Dispose()
        {
            _clientRepository.Dispose();
        }
    }
}
