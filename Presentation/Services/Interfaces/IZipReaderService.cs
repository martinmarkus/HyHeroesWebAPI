using HyHeroesWebAPI.Presentation.DTOs;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.Services.Interfaces
{
    public interface IZipReaderService
    {
        IList<ZipCode> ReadInZipData();
    }
}
