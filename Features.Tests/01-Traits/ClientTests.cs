using Feature.Clients;
using System;
using Xunit;

namespace Features.Tests._01_Traits
{
    public class ClientTests
    {
        [Fact(DisplayName ="New Client Valid")]
        [Trait("Category", "Client Trait Tests")]
        public void Client_NewClient_MustBeValid()
        {
            //Arrange
            var cliente = new Client(
                Guid.NewGuid(),
                name: "Natt",
                surname: "Souza",
                birthday: DateTime.Now.AddYears(-37),
                email: "natt@nso.com.br",
                active: true,
                registrationDate: DateTime.Now);

            //Act
            var result = cliente.IsValid();

            //Assert
            Assert.True(result);
            Assert.Equal(expected: 0, actual: cliente.ValidationResult.Errors.Count);
        }

        [Fact(DisplayName ="Client Test Invalid")]
        [Trait("Category","Client Trait Tests")]
        public void Client_NewClient_MustBeNotValid()
        {
            //Arrange
            var cliente = new Client(
                Guid.NewGuid(),
                name: "",
                surname: "",
                birthday: DateTime.Now.AddYears(-37),
                email: "natt@nso.com.br",
                active: true,
                registrationDate: DateTime.Now);

            //Act
            var result = cliente.IsValid();

            //Assert
            Assert.False(result);
            Assert.NotEqual(expected: 0, actual: cliente.ValidationResult.Errors.Count);
        }
    }
}
