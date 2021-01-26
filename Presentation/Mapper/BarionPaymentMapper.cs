using BarionClientLibrary.Operations.Common;
using BarionClientLibrary.Operations.StartPayment;
using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.ApplicationCore.Enums;
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

        public StartPaymentOperation MapToBarionPaymentDTO(BarionPaymentTransactionDTO paymentDTO)
        {
            var totalCost = GetTotalCost(paymentDTO.KreditAmount);

            var paymentId = Guid.NewGuid().ToString();
            var operation = new StartPaymentOperation()
            {
                PaymentType = BarionClientLibrary.Operations.Common.PaymentType.Immediate,    // INFO: always instant payment type
                PaymentWindow = new TimeSpan(0, 30, 0),
                GuestCheckOut = true,                   // INFO: payment can be done without barion account
                FundingSources = new FundingSourceType[] { FundingSourceType.All },
                RedirectUrl = _options.Value.CustomBarionSettings.RedirectURL + paymentId,
                CallbackUrl = _options.Value.CustomBarionSettings.CallbackURL,
                OrderNumber = paymentId,
                Locale = new CultureInfo(paymentDTO.Locale),
                Currency = (Currency)Enum.Parse(typeof(Currency), paymentDTO.CurrencyType),

                Transactions = new PaymentTransaction[]
                {
                    new PaymentTransaction()
                    {
                        POSTransactionId = paymentId,
                        Payee = paymentDTO.PayeeEmail,
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

        public BarionTransaction MapToBarionTransaction(
            BarionPaymentTransactionDTO paymentTransactionDTO,
            StartPaymentOperationResult result,
            Guid userId,
            BarionTransactionState state) =>
            new BarionTransaction()
            {
                KreditAmount = paymentTransactionDTO.KreditAmount,
                PaymentId = result.PaymentId,
                TotalCost = GetTotalCost(paymentTransactionDTO.KreditAmount),
                UserId = userId,
                State = state
            };

        public BarionBillingAddress MapToBarionBillingAddress(BarionBillingAddressDTO addressDTO, Guid barionTransactionId) =>
            new BarionBillingAddress()
            {
                BarionTransactionId = barionTransactionId,
                Country = addressDTO.Country,
                Zip = addressDTO.Zip,
                City = addressDTO.City,
                Region = addressDTO.Region,
                Street = addressDTO.Street,
                Street2 = addressDTO.Street2,
                Street3 = addressDTO.Street3
            };

        public KreditPurchase MapToKreditPurchase(
            BarionPaymentTransactionDTO paymentTransactionDTO,
            Guid userId) =>
            new KreditPurchase()
            {
                CurrencyValue = GetTotalCost(paymentTransactionDTO.KreditAmount),
                KreditValue = Convert.ToInt32(paymentTransactionDTO.KreditAmount),
                PaymentType = ApplicationCore.Enums.PaymentType.Barion,
                UserId = userId
            };

        private int GetTotalCost(double kreditAmount)
        {
            var totalCost = -1;

            foreach (var type in _options.Value.CustomBarionSettings.BarionPurchaseTypes)
            {
                if (type.KreditValue.Equals(kreditAmount))
                {
                    totalCost = type.GrossPrice;
                    break;
                }
            }

            if (totalCost <= 0)
            {
                throw new BarionPaymentStartException();
            }

            return totalCost;
        }
    }
}
