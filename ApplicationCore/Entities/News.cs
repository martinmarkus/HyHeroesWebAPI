using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HyHeroesWebAPI.ApplicationCore.Entities
{
    [Table("news")]
    public class News : BaseEntity
    {
        [Required]
        public string Title { get; set; }

        public string Preview { get; set; }

        [Required]
        public string FormattedNews { get; set; }

        [Required]
        public Guid PublisherUserId { get; set; }

        [Required]
        public User PublisherUser { get; set; }
    }
}
