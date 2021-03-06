﻿using Newtonsoft.Json;
using System;

namespace HyHeroesWebAPI.Presentation.DTOs.UserDTOs
{
    [Serializable]
    public class ZipCode
    {
        [JsonProperty("zip")]
        public int Zip { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }
    }
}
