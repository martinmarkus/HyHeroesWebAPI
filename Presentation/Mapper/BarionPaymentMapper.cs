using BarionClientLibrary.Operations.Common;
using BarionClientLibrary.Operations.StartPayment;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Exceptions;
using HyHeroesWebAPI.Presentation.ConfigObjects;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Mapper.Interfaces;
using Microsoft.Extensions.Options;
using System;
using System.Globalization;

namespace HyHeroesWebAPI.Presentation.Mapper
{
    public class BarionPaymentMapper : IBarionPaymentMapper
    {
        private readonly IOptions<AppSettings> _options;

        public BarionPaymentMapper(IOptions<AppSettings> options)
        {
            _options = options ?? throw new ArgumentException(nameof(options));
        }

        public StartPaymentOperation MapToBarionPaymentDTO(BarionPaymentTransactionDTO paymentDTO, string userEmail)
        {
            var totalCost = -1;

            foreach (var type in _options.Value.CustomBarionSettings.BarionPurchaseTypes)
            {
                if (type.KreditValue.Equals(paymentDTO.KreditAmount))
                {
                    totalCost = type.GrossPrice;
                    break;
                }
            }

            if (totalCost <= 0)
            {
                throw new BarionPaymentStartException();
            }

            var paymentId = Guid.NewGuid().ToString();
            var operation = new StartPaymentOperation()
            {
                PaymentType = PaymentType.Immediate,    // INFO: always instant payment type
                PaymentWindow = new TimeSpan(0, 30, 0),
                GuestCheckOut = true,                   // INFO: payment can be done without barion account
                FundingSources = new FundingSourceType[] { FundingSourceType.All },
                RedirectUrl = _options.Value.CustomBarionSettings.RedirectURL + paymentId,
                CallbackUrl = _options.Value.CustomBarionSettings.CallbackURL,
                OrderNumber = paymentId,
                Locale = new CultureInfo(paymentDTO.Locale),
                Currency = (Currency)Enum.Parse(typeof(Currency), paymentDTO.Currency),

                Transactions = new PaymentTransaction[]
                {
                    new PaymentTransaction()
                    {
                        POSTransactionId = paymentId,
                        Payee = userEmail,
                        Total = totalCost,
                        Comment = paymentDTO.Comment,
                        Items = new Item[]
                        {
                            new Item()
                            {
                                Name = "Digital currency/Digitális valuta",
                                Description = "Hyeroes Kredit",
                                Quantity = paymentDTO.KreditAmount,
                                Unit = "Kredit",
                                ItemTotal = totalCost
                            }
                        }

                    }
                },
                BillingAddress = new BillingAddress()
                {
                    City = paymentDTO.BarionBillingAddressDTO.City,
                    Country = paymentDTO.BarionBillingAddressDTO.Country,
                    Zip = paymentDTO.BarionBillingAddressDTO.Zip,
                    Region = paymentDTO.BarionBillingAddressDTO.Region,
                    Street = paymentDTO.BarionBillingAddressDTO.Street,
                    Street2 = paymentDTO.BarionBillingAddressDTO.Street2,
                    Street3 = paymentDTO.BarionBillingAddressDTO.Street3
                }
            };

            return operation;
        }
    }
}
