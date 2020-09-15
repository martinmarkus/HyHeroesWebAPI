using HyHeroesWebAPI.Presentation.Facades.Interfaces;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Facades
{
    public class RecurringTaskFacade : IRecurringTaskFacade
    {
        public void StartRecurringTask(Action action, int seconds, CancellationToken token)
        {
            if (action == null || seconds <= 0 || token == null)
            {
                throw new ArgumentException();
            }

            Task.Run(async () => {
                while (!token.IsCancellationRequested)
                {
                    action();
                    await Task.Delay(TimeSpan.FromSeconds(seconds), token);
                }
            }, token);
        }
    }
}
