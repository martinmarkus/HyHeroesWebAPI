using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class NewsDTO
    {
        [Required]
        [JsonProperty("formattedNews")]
        public string FormattedNews { get; set; }
        [Required]
        [JsonProperty("publishDate")]
        public DateTime PublishDate { get; set; }

        [Required]
        [JsonProperty("publisherName")]
        public string PublisherName { get; set; }
    }
}
