using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services.Interfaces
{
    public interface IDbListenerService
    {
        void Start(int interval = 60);
        void Stop();
    }
}
