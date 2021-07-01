using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorSample.ClientApp.Pattern.Simple
{

    public abstract class Colleague
    {
        private readonly Mediator mediator;

        public Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }
        public virtual void Send(string message)
        {
            mediator.Send(message, this);
        }
        public abstract void Receive(string message);
    }
    public class Colleague01 : Colleague
    {
        public Colleague01(Mediator mediator) : base(mediator)
        {
        }

        public override void Receive(string message)
        {
            Console.WriteLine($"Colleague01: {message}");
        }
    }


    public class Colleague02 : Colleague
    {
        public Colleague02(Mediator mediator) : base(mediator)
        {
        }

        public override void Receive(string message)
        {
            Console.WriteLine($"Colleague02: {message}");
        }
    }
}
