using System.Collections.Generic;
using System.Linq;

namespace MediatorSample.ClientApp.Pattern.Advanced
{

    public class AdvancedMediator : Mediator
    {
        private List<AdvancedColleague> colleagues = new List<AdvancedColleague>();

        public void AddColleague(AdvancedColleague colleague)
        {
            colleagues.Add(colleague);
            colleague.SetMediator(this);
        }


        public TColleague CreateColleague<TColleague>()where TColleague:AdvancedColleague,new()
        {
            TColleague colleague = new TColleague();
            AddColleague(colleague);
            return colleague;
        }
        public override void Send(string message, AdvancedColleague colleague)
        {
            foreach (var item in colleagues.Where(c=>c != colleague))
            {
                item.Receive(message);
            }
        }
    }
}
