using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Extensions;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Mappers.Interfaces;
using System;
using HyHeroesWebAPI.Presentation.DTOs.PayPalDTOs;

namespace HyHeroesWebAPI.Presentation.Mappers
{
    public class PayPalMapper : IPayPalMapper
    {
        public PayPalIPNMessage MapToIPNMessage(
            string mc_gross,
            string protection_eligibility,
            string address_status,
            string payer_id,
            string tax,
            string address_street,
            string payment_date,
            string payment_status,
            string charset,
            string address_zip,
            string first_name,
            string mc_fee,
            string address_country_code,
            string address_name,
            string notify_version,
            string custom,
            string payer_status,
            string address_country,
            string address_city,
            string quantity,
            string verify_sign,
            string payer_email,
            string txn_id,
            string payment_type,
            string last_name,
            string address_state,
            string receiver_email,
            string payment_fee,
            string receiver_id,
            string item_name,
            string mc_currency,
            string item_number,
            string residence_country,
            string test_ipn,
            string handling_amount,
            string transaction_subject,
            string payment_gross,
            string shipping) =>
            new PayPalIPNMessage()
            {
                McGross = mc_gross.GetAsDecimal(),
                ProtectionEligibility = protection_eligibility,
                AddressStatus = address_status,
                PayerId = payer_id,
                Tax = tax.GetAsDecimal(),
                AddressStreet = address_street,
                PaymentDate = payment_date.GetAsDateTime(),
                PaymentStatus = payment_status,
                Charset = charset,
                AddressZip = address_zip,
                FirstName = first_name,
                McFee = mc_fee.GetAsDecimal(),
                AddressCountryCode = address_country_code,
                AddressName = address_name,
                NotifyVersion = notify_version,
                Custom = custom,
                PayerStatus = payer_status,
                AddressCountry = address_country,
                AddressCity = address_city,
                Quantity = quantity.GetAsInt32(),
                VerifySign = verify_sign,
                PayerEmail = payer_email,
                TxnId = txn_id,
                PaymentType = payment_type,
                LastName = last_name,
                AddressState = address_state,
                ReceiverEmail = receiver_email,
                PaymentFee = payment_fee.GetAsDecimal(),
                ReceiverId = receiver_id,
                ItemName = item_name,
                McCurrency = mc_currency,
                ItemNumber = item_number,
                ResidenceCountry = residence_country,
                TestIpn = test_ipn,
                HandlingAmount = handling_amount,
                TransactionSubject = transaction_subject,
                PaymentGross = payment_gross.GetAsDecimal(),
                Shipping = shipping
            };

        public PayPalIPNMessage MapToIPNMessage(PayPalIPNMessageDTO dto) =>
            new PayPalIPNMessage()
            {
                McGross = dto.mc_gross.GetAsDecimal(),
                ProtectionEligibility = dto.protection_eligibility,
                AddressStatus = dto.address_status,
                PayerId = dto.payer_id,
                Tax = dto.tax.GetAsDecimal(),
                AddressStreet = dto.address_street,
                PaymentDate = dto.GetAsDateTime(),
                PaymentStatus = dto.payment_status,
                Charset = dto.charset,
                AddressZip = dto.address_zip,
                FirstName = dto.first_name,
                McFee = dto.mc_fee.GetAsDecimal(),
                AddressCountryCode = dto.address_country_code,
                AddressName = dto.address_name,
                NotifyVersion = dto.notify_version,
                Custom = dto.custom,
                PayerStatus = dto.payer_status,
                AddressCountry = dto.address_country,
                AddressCity = dto.address_city,
                Quantity = dto.quantity.GetAsInt32(),
                VerifySign = dto.verify_sign,
                PayerEmail = dto.payment_email,
                TxnId = dto.txn_id,
                PaymentType = dto.payment_type,
                LastName = dto.last_name,
                AddressState = dto.address_state,
                ReceiverEmail = dto.receiver_email,
                PaymentFee = dto.payment_fee.GetAsDecimal(),
                ReceiverId = dto.receiver_id,
                ItemName = dto.item_name,
                McCurrency = dto.mc_currency,
                ItemNumber = dto.item_number,
                ResidenceCountry = dto.residence_country,
                TestIpn = dto.test_ipn,
                HandlingAmount = dto.handling_amount,
                TransactionSubject = dto.transaction_subject,
                PaymentGross = dto.payment_gross.GetAsDecimal(),
                Shipping = dto.shipping
            };

        public PayPalIPNMessage MapToIPNMessage(string rawIPNBody)
        {
            var ipnMessageDTO = new PayPalIPNMessageDTO();
            var splitedBody = rawIPNBody.Split("&");

            foreach (var bodyElement in splitedBody)
            {
                var splitedElement = bodyElement.Split("=");
                var key = splitedElement[0].Replace("%20", " ");
                var value = splitedElement[1].Replace("%20", " ");

                foreach (var ipnProp in ipnMessageDTO.GetType().GetProperties())
                {
                    try
                    {
                        if (ipnProp.Name.Equals(key, StringComparison.OrdinalIgnoreCase))
                        {
                            ipnProp.SetValue(ipnMessageDTO, value);
                            break;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }

            return MapToIPNMessage(ipnMessageDTO);
        }
    }
}
