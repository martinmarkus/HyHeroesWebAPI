using System;
using System.Threading;

namespace HyHeroesWebAPI.Presentation.Facades.Interfaces
{
    public interface IRecurringTaskFacade
    {
        void StartRecurringTask(Action action, int seconds, CancellationToken token);
    }
}
