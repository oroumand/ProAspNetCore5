using MediatorSample.ClientApp.Pattern;
using MediatorSample.ClientApp.Pattern.Advanced;
using MediatorSample.ClientApp.Pattern.Simple;
using System;

namespace MediatorSample.ClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //SimpleMediator();
            var mediator = new AdvancedMediator();
            var c01 = mediator.CreateColleague<AdvancedColleague01>();
            var c02 = mediator.CreateColleague<AdvancedColleague02>();
            var c03 = mediator.CreateColleague<AdvancedColleague03>();
            //mediator.AddColleague(c01);
            //mediator.AddColleague(c02);

            c01.Send("Hello");

            c02.Send("aleyke hello");


            Console.ReadKey();
            Console.WriteLine("Hello World!");
        }

        private static void SimpleMediator()
        {
            Console.WriteLine("Start Simple Mediator");
            var simpleMediator = new SimpleMediator();

            var c01 = new Colleague01(simpleMediator);
            var c02 = new Colleague02(simpleMediator);

            simpleMediator.Colleague01 = c01;
            simpleMediator.Colleague02 = c02;


            c01.Send("Hello");

            c02.Send("aleyke hello");
            Console.WriteLine("".PadLeft(100, '*'));
        }
    }
}
