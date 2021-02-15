using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Presentation.DTOs;

namespace HyHeroesWebAPI.Presentation.Mappers.Interfaces
{
    public interface IPayPalMapper
    {
        PayPalIPNMessage MapToIPNMessage(
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
            string shipping);
        PayPalIPNMessage MapToIPNMessage(PayPalIPNMessageDTO payPalIPNMessageDTO);

        PayPalIPNMessage MapToIPNMessage(string rawIPNBody);
    }
}
