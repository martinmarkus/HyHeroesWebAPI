using HyHeroesWebAPI.Presentation.DTOs.BankTransferDTOs;
using HyHeroesWebAPI.Presentation.DTOs.BarionDTOs;
using HyHeroesWebAPI.Presentation.DTOs.EDSMSDTOs;
using HyHeroesWebAPI.Presentation.DTOs.PayPalDTOs;
using HyHeroesWebAPI.Presentation.DTOs.UserDTOs;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace HyHeroesWebAPI.Presentation.DTOs.WebsiteDTOs
{
    public class KreditUploadDTO
    {
        [JsonProperty("user")]
        public AuthenticatedUserDTO User { get; set; }

        [JsonProperty("barionPurchaseTypeList")]
        public BarionPurchaseTypeListDTO BarionPurchaseTypeList { get; set; }

        [JsonProperty("bankTransferTypeList")]
        public BankTransferTypeListDTO BankTransferTypeList { get; set; }

        [JsonProperty("acceptedCountryList")]
        public AcceptedCountryListDTO AcceptedCountryList { get; set; }

        [JsonProperty("EDSMSTypeList")]
        public EDSMSPurchaseTypeListDTO EDSMSTypeList { get; set; }

        [JsonProperty("payPalPurchaseTypeList")]
        public PayPalPurchaseTypeListDTO PayPalPurchaseTypeList { get; set; }

        [JsonProperty("zips")]
        public IList<ZipCode> Zips { get; set; } = new List<ZipCode>();
    }
}
