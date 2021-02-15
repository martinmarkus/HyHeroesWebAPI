using HyHeroesWebAPI.Infrastructure.Infrastructure.DataObjects;
using HyHeroesWebAPI.Infrastructure.Infrastructure.DTOs.SzamlazzHu;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Facades.Interfaces;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Mappers.Interfaces;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Services.Interfaces;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Infrastructure.Infrastructure.Services
{
    public class SzamlazzHuBillService : ISzamlazzHuBillService
    {
        private readonly ISzamlazzHuRequestService _szamlazzHuRequestService;
        private readonly IXmlSerializerFacade _xmlSerializerFacade;
        private readonly IBillMapper _billMapper;

        public SzamlazzHuBillService(
            ISzamlazzHuRequestService szamlazzHuRequestService,
            IXmlSerializerFacade xmlSerializerFacade,
            IBillMapper billMapper)
        {
            _szamlazzHuRequestService = szamlazzHuRequestService ?? throw new ArgumentException(nameof(szamlazzHuRequestService));
            _xmlSerializerFacade = xmlSerializerFacade ?? throw new ArgumentException(nameof(xmlSerializerFacade));
            _billMapper = billMapper ?? throw new ArgumentException(nameof(billMapper));
        }

        public async Task<BillCreationResponse> CreateBill(CreateBillDTO createBillDTO)
        {
            var szamlazzHuBillDTO = _billMapper.Map(createBillDTO);

            var billByteArray = _xmlSerializerFacade.SerializeToByteArray(szamlazzHuBillDTO);
            var response = _szamlazzHuRequestService.SendRequest(billByteArray, "action-xmlagentxmlfile");

            var errorCode = GetErrorCode(response);
            var pdf = string.IsNullOrEmpty(errorCode) ? await GetSzamlazzHuPDFAsync(response) : string.Empty;

            var billXml = _xmlSerializerFacade.SerializeToString(szamlazzHuBillDTO);

            return new BillCreationResponse()
            {
                IsCreated = string.IsNullOrEmpty(errorCode),
                RequestXml = billXml,
                CreatedPDF = pdf,
                ErrorCode = errorCode
            };
        }

        private async Task<string> GetSzamlazzHuPDFAsync(HttpResponseMessage response) =>
            await response.Content.ReadAsStringAsync();

        private string GetErrorCode(HttpResponseMessage response)
        {
            var errorCode = string.Empty;

            try
            {
                errorCode = response.Headers
                    .GetValues("szlahu_error_code")
                    .FirstOrDefault();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return errorCode;
        }
    }
}
