namespace MediatorSample.ClientApp.Pattern.Advanced
{
    public abstract class Mediator
    {
        public abstract void Send(string message, AdvancedColleague colleague);
    }
}
