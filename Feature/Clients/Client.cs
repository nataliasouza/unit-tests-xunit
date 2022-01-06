using Feature.Core;
using Feature.Core.Validations;
using System;

namespace Feature.Clients
{
    public class Client : Entity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }

        protected Client() { }

        public Client(Guid id, string name, string surname, DateTime birthday,
            string email, bool active, DateTime registrationDate)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Birthday = birthday;
            RegistrationDate = registrationDate;
            Email = email;
            Active = active;
        }

        public string FullName()
        {
            return $"{Name} { Surname}";
        }

        public bool IsEspecial()
        {
            return RegistrationDate < DateTime.Now.AddYears(-3) && Active;
        }

        public void Inactivate()
        {
            Active = false;
        }

        public override bool IsValid()
        {
            ValidationResult = new ClientValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}