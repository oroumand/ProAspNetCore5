using System.Collections.Generic;

namespace MediatorSample.ClientApp.Pattern.Simple
{
    public class SimpleMediator : Mediator
    {
        public Colleague01 Colleague01 { get; set; }
        public Colleague02 Colleague02 { get; set; }
        public override void Send(string message, Colleague colleague)
        {
            if (colleague == Colleague01)
            {
                Colleague02.Receive(message);
            }
            else if (colleague == Colleague02)
            {
                Colleague01.Receive(message);
            }
        }
    }   
}
