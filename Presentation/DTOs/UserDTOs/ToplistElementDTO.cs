﻿using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.Presentation.DTOs.UserDTOs
{
    public class ToplistElementDTO
    {
        [RegularExpression(@"^[a-zA-Z0-9_]{3,20}$")]
        public string UserName { get; set; }
        public int HyCoin { get; set; }
    }
}
