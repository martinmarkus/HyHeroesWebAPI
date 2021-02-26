using Newtonsoft.Json;
using System;

namespace HyHeroesWebAPI.Presentation.DTOs
{
    public class UserKreditGiftingsDTO
    {
        [JsonProperty("senderUserName")]
        public string SenderUserName { get; set; }

        [JsonProperty("receiverUserName")]
        public string ReceiverUserName { get; set; }

        [JsonProperty("kreditValue")]
        public int KreditValue { get; set; }

        [JsonProperty("giftingDate")]
        public DateTime GiftingDate { get; set; }
    }
}
