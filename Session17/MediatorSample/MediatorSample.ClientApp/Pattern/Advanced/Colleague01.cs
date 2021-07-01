using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorSample.ClientApp.Pattern.Advanced
{

    public abstract class AdvancedColleague
    {
        private Mediator mediator;

        public void SetMediator(Mediator mediator)
        {
            this.mediator = mediator;
        }

        public virtual void Send(string message)
        {
            mediator.Send(message, this);
        }
        public abstract void Receive(string message);
    }
    public class AdvancedColleague01 : AdvancedColleague
    {


        public override void Receive(string message)
        {
            Console.WriteLine($"Colleague01: {message}");
        }
    }


    public class AdvancedColleague02 : AdvancedColleague
    {
        public override void Receive(string message)
        {
            Console.WriteLine($"Colleague02: {message}");
        }
    }

    public class AdvancedColleague03 : AdvancedColleague
    {
        public override void Receive(string message)
        {
            Console.WriteLine($"Colleague03: {message}");
        }
    }
}
