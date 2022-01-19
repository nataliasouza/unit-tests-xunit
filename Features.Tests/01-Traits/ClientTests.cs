using Feature.Clients;
using Features.Tests._02_Fixtures;
using System;
using Xunit;

namespace Features.Tests._01_Traits
{
    [Collection(nameof(ClientCollection))]
    public class ClientTests
    {
        private readonly ClientFixtureTests _clientTestsFixture;

        public ClientTests(ClientFixtureTests clientFixtureTests)
        {
            _clientTestsFixture = clientFixtureTests;                
        }

        [Fact(DisplayName ="New Client Valid")]
        [Trait("Category", "Client Trait Tests")]
        public void Client_NewClient_MustBeValid()
        {
            //Arrange
            var cliente = _clientTestsFixture.GenerateClientValid();

            //Act
            var result = cliente.IsValid();

            //Assert
            Assert.True(result);
            Assert.Equal(expected: 0, actual: cliente.ValidationResult.Errors.Count);
        }

        [Fact(DisplayName ="New Client Invalid")]
        [Trait("Category","Client Trait Tests Invalid")]
        public void Client_NewClient_MustBeNotValid()
        {
            //Arrange
            var cliente = _clientTestsFixture.GenerateClientInvalid();

            //Act
            var result = cliente.IsValid();

            //Assert
            Assert.False(result);
            Assert.NotEqual(expected: 0, actual: cliente.ValidationResult.Errors.Count);
        }
    }
}
