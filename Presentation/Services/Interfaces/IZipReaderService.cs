using HyHeroesWebAPI.Presentation.DTOs.UserDTOs;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.Services.Interfaces
{
    public interface IZipReaderService
    {
        IList<ZipCode> ReadInZipData();
    }
}
