using BarionClientLibrary.Operations.Common;
using BarionClientLibrary.Operations.StartPayment;
using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.ApplicationCore.Enums;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Exceptions;
using HyHeroesWebAPI.Infrastructure.Infrastructure.ConfigObjects;
using HyHeroesWebAPI.Presentation.Mappers.Interfaces;
using Microsoft.Extensions.Options;
using System;
using System.Globalization;
using HyHeroesWebAPI.Presentation.DTOs.BarionDTOs;

namespace HyHeroesWebAPI.Presentation.Mappers
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

            var street2 = string.Empty;
            var street3 = string.Empty;

            if (paymentDTO.BarionBillingAddressDTO.Street.Length > 50)
            {
                street2 = paymentDTO.BarionBillingAddressDTO.Street.Substring(50);
                paymentDTO.BarionBillingAddressDTO.Street = paymentDTO.BarionBillingAddressDTO.Street.Substring(0, 50);
                if (street2.Length > 50)
                {
                    street3 = street2.Substring(50);
                    street2 = street2.Substring(0, 50);
                    if (street3.Length > 50)
                    {
                        street3 = street3.Substring(0, 50);
                    }
                }
            }

            return new StartPaymentOperation()
            {
                PaymentType = BarionClientLibrary.Operations.Common.PaymentType.Immediate,
                PaymentWindow = new TimeSpan(0, 30, 0),
                GuestCheckOut = true, // INFO: payment can be done without barion account
                FundingSources = new FundingSourceType[] { FundingSourceType.All },
                RedirectUrl = _options.Value.CustomBarionSettings.RedirectURL,
                CallbackUrl = _options.Value.CustomBarionSettings.CallbackURL,
                OrderNumber = paymentId,
                Locale = new CultureInfo("hu-HU"),
                Currency = Currency.HUF,

                Transactions = new PaymentTransaction[]
                {
                    new PaymentTransaction()
                    {
                        POSTransactionId = paymentId,
                        Payee = _options.Value.CustomBarionSettings.BarionShopEmail,
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
                    City = paymentDTO.BarionBillingAddressDTO.City.ToUpper(),
                    Country = paymentDTO.BarionBillingAddressDTO.Country.ToUpper(),
                    Zip = paymentDTO.BarionBillingAddressDTO.Zip.ToString().ToUpper(),
                    Street = paymentDTO.BarionBillingAddressDTO.Street.ToUpper(),
                    Street2 = !string.IsNullOrEmpty(street2) ? street2.ToUpper() : string.Empty,
                    Street3 = !string.IsNullOrEmpty(street3) ? street3.ToUpper() : string.Empty
                }
            };
        }

        public BarionTransaction MapToBarionTransaction(
            BarionPaymentTransactionDTO paymentTransactionDTO,
            StartPaymentOperationResult result,
            Guid userId,
            BarionTransactionState state) =>
            new BarionTransaction()
            {
                BillingName = paymentTransactionDTO.BillingName,
                BillingEmail = paymentTransactionDTO.BillingEmail,
                KreditAmount = paymentTransactionDTO.KreditAmount,
                TotalCost = GetTotalCost(paymentTransactionDTO.KreditAmount),
                UserId = userId,
                State = state,
                GatewayURL = !string.IsNullOrEmpty(result.GatewayUrl) ? result.GatewayUrl : string.Empty,
                PaymentId = result.PaymentId
            };

        public BarionBillingAddress MapToBarionBillingAddress(BarionBillingAddressDTO addressDTO, Guid barionTransactionId) =>
            new BarionBillingAddress()
            {
                BarionTransactionId = barionTransactionId,
                Country = addressDTO.Country,
                Zip = addressDTO.Zip.ToString(),
                City = addressDTO.City,
                Street = addressDTO.Street
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

            foreach (var type in _options.Value.BarionPurchaseTypes)
            {
                if (type.KreditValue == kreditAmount)
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

        public BarionPurchaseTypeListDTO MapToBarionPurchaseTypeListDTO(BarionPurchaseType[] barionPurchaseTypes)
        {
            var typeListDTO = new BarionPurchaseTypeListDTO();

            foreach (var type in barionPurchaseTypes)
            {
                typeListDTO.BarionPurchaseTypes.Add(new BarionPurchaseTypeDTO() 
                { 
                    GrossValue = type.GrossPrice,
                    KreditValue = type.KreditValue
                });
            }

            return typeListDTO;
        }

        public KreditPurchase MapToKreditPurchase(BarionTransaction barionTransaction) =>
            new KreditPurchase()
            {
                CurrencyValue = Convert.ToInt32(barionTransaction.TotalCost),
                KreditValue = Convert.ToInt32(barionTransaction.KreditAmount),
                PaymentType = ApplicationCore.Enums.PaymentType.Barion,
                UserId = barionTransaction.UserId
            };
    }
}
