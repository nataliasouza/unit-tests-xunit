using MediatR;

namespace Feature.Clients
{
    public class ClientEmailNotification : INotification
    {        
        public string Origin { get; private set; }
        public string Destiny { get; private set; }
        public string Matters { get; private set; }
        public string Message { get; private set; }

        public ClientEmailNotification(string origin, string destiny, string matters, string message)
        {
            Origin = origin;
            Destiny = destiny;
            Matters = matters;
            Message = message;
        }
    }
}
