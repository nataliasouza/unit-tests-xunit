using Feature.Clients;
using System;
using Xunit;

namespace Features.Tests._02_Fixtures
{
    [CollectionDefinition(nameof(ClientCollection))]
    public class ClientCollection : ICollectionFixture<ClientFixtureTests>
    {}

    public class ClientFixtureTests : IDisposable
    {        
        public Client GenerateClientValid()
        {
            var cliente = new Client(
                Guid.NewGuid(),
                name: "Natt",
                surname: "Souza",
                birthday: DateTime.Now.AddYears(-37),
                email: "natt@nso.com.br",
                active: true,
                registrationDate: DateTime.Now);

            return cliente;
        }

        public Client GenerateClientInvalid()
        {
            var cliente = new Client(
                Guid.NewGuid(),
                name: "",
                surname: "",
                birthday: DateTime.Now.AddYears(-37),
                email: "natt@nso.com.br",
                active: true,
                registrationDate: DateTime.Now);

            return cliente;
        }

        public void Dispose()
        {

        }
    }
}
