﻿using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.Presentation.DTOs.NewsDTOs
{
    public class NewsDTO
    {
        [Required]
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("preview")]
        public string Preview { get; set; }

        [Required]
        [JsonProperty("formattedNews")]
        public string FormattedNews { get; set; }

        [Required]
        [JsonProperty("publishDate")]
        public string PublishDate { get; set; }

        [Required]
        [JsonProperty("publisherName")]
        public string PublisherName { get; set; }

        [Required]
        [JsonProperty("id")]
        public Guid Id { get; set; }
    }
}
