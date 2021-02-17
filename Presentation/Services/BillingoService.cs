using HyHeroesWebAPI.Infrastructure.Persistence.Repositories.Interfaces;
using HyHeroesWebAPI.Presentation.ConfigObjects;
using HyHeroesWebAPI.Presentation.Mappers.Interfaces;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using Microsoft.Extensions.Options;
using System;
using System.Threading.Tasks;

namespace HyHeroesWebAPI.Presentation.Services
{
    public class BillingoService : IBillingoService
    {
        private readonly IBillingoDocumentRepository _billingoDocumentRepository;
        private readonly IBillingoDocumentSettingsRepository _billingoDocumentSettingsRepository;
        private readonly IBillingoBillingAddressRepository _billingoBillingAddressRepository;
        private readonly IBillingoPartnerRepository _billingoPartnerRepository;
        private readonly IBillingoProductRepository _billingoProductRepository;

        private readonly IBillingoMapper _billingoMapper;
        private readonly IOptions<AppSettings> _options;

        public BillingoService(
            IBillingoDocumentRepository billingoDocumentRepository,
            IBillingoDocumentSettingsRepository billingoDocumentSettingsRepository, 
            IBillingoBillingAddressRepository billingoBillingAddressRepository,
            IBillingoPartnerRepository billingoPartnerRepository,
            IBillingoProductRepository billingoProductRepository,
            IBillingoMapper billingoMapper,
            IOptions<AppSettings> options)
        {
            _billingoDocumentRepository = billingoDocumentRepository ?? throw new ArgumentException(nameof(billingoDocumentRepository));
            _billingoDocumentSettingsRepository = billingoDocumentSettingsRepository ?? throw new ArgumentException(nameof(billingoDocumentSettingsRepository));
            _billingoBillingAddressRepository = billingoBillingAddressRepository ?? throw new ArgumentException(nameof(billingoBillingAddressRepository));
            _billingoPartnerRepository = billingoPartnerRepository ?? throw new ArgumentException(nameof(billingoPartnerRepository));
            _billingoProductRepository = billingoProductRepository ?? throw new ArgumentException(nameof(billingoProductRepository));

            _billingoMapper = billingoMapper ?? throw new ArgumentException(nameof(billingoMapper));

            _options = options ?? throw new ArgumentException(nameof(options));
        }

        public async Task CreateBillAsync()
        {
            throw new NotImplementedException();
        }
    }
}
