using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Session13Components.Structures.Pages
{
    public partial class Counter: IAsyncDisposable
    {
        private int currentCount = 0;

        public ValueTask DisposeAsync()
        {
            throw new NotImplementedException();
        }

        private void IncrementCount()
        {
            currentCount++;
        }
    }
}
