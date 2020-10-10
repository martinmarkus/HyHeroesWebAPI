using System;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using HyHeroesWebAPI.ApplicationCore.Entities;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Services.Interfaces;
using HyHeroesWebAPI.Presentation.ConfigObjects;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Filters;
using HyHeroesWebAPI.Presentation.Mapper;
using HyHeroesWebAPI.Presentation.Mapper.Interfaces;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace HyHeroesWebAPI.Presentation.Controllers
{
    [Route("[controller]")]
    public class CurrencyController : AuthorizableBaseController
    {
        private readonly IOptions<AppSettings> _options;
        private readonly IEDSMSService _EDSMSService;
        private readonly IEDSMSMapper _EDSMSMapper;
        private readonly IPayPalService _payPalService;
        private readonly IPayPalMapper _payPalMapper;

        public CurrencyController(
            IOptions<AppSettings> options,
            IUserService userService,
            IAuthorizerService authorizationService,
            IEDSMSService EDSMSService,
            IEDSMSMapper EDSMSMapper,
            IPayPalService payPalService,
            IPayPalMapper payPalMapper)
            : base(userService, authorizationService)
        {
            _options = options ?? throw new ArgumentException(nameof(options));
            _EDSMSService = EDSMSService ?? throw new ArgumentException(nameof(EDSMSService));
            _EDSMSMapper = EDSMSMapper ?? throw new ArgumentException(nameof(EDSMSMapper));
            _payPalService = payPalService ?? throw new ArgumentException(nameof(payPalService));
            _payPalMapper = payPalMapper ?? throw new ArgumentException(nameof(payPalMapper));
        }

        [RequiredRole("Admin")]
        [ExceptionHandler]
        [HttpPost("AddKredit", Name = "addKredit")]
        [ProducesResponseType(typeof(ModifiedKreditDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> AddKredit([FromBody] KreditTransactionDTO kreditTransactionDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                var newValue = await UserService.AddKreditAsync(kreditTransactionDTO);

                return Ok(new ModifiedKreditDTO()
                {
                    NewValue = newValue
                });
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        // Will not be used, because use-case specific endpoints are implemented.
        [Obsolete]
        [RequiredRole("User")]
        [ExceptionHandler]
        [HttpPost("StartKreditPurchaseTransaction", Name = "startKreditPurchaseTransaction")]
        [ProducesResponseType(typeof(EmptyDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public IActionResult StartKreditPurchaseTransaction([FromBody] KreditPurchaseTransactionDTO kreditTransactionDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                //await UserService.PurchaseKreditAsync(kreditTransactionDTO);
            }
            catch (Exception e)
            {
                throw e;
            }

            return Ok();
        }

        [RequiredRole("Admin")]
        [ExceptionHandler]
        [ExceptionHandler]
        [HttpPost("RemoveKredit", Name = "removeKredit")]
        [ProducesResponseType(typeof(ModifiedKreditDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> RemoveKredit([FromBody] KreditTransactionDTO kreditTransactionDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                var newValue = await UserService.RemoveKreditAsync(kreditTransactionDTO);

                return Ok(new ModifiedKreditDTO()
                {
                    NewValue = newValue
                });
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        [RequiredRole("Admin")]
        [ExceptionHandler]
        [HttpPost("ResetKredit", Name = "resetKredit")]
        [ProducesResponseType(typeof(ModifiedKreditDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> ResetKredit([FromBody] KreditResetDTO kreditResetDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                var newValue = await UserService.ResetKreditAsync(kreditResetDTO.UserName);

                return Ok(new ModifiedKreditDTO()
                {
                    NewValue = newValue
                });
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [RequiredRole("Admin")]
        [ExceptionHandler]
        [HttpPost("AddHyCoin", Name = "addHyCoin")]
        [ProducesResponseType(typeof(ModifiedKreditDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> AddHyCoin([FromBody] HyCoinTransactionDTO hyCoinTransactionDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                var newValue = await UserService.AddHyCoinAsync(hyCoinTransactionDTO);

                return Ok(new ModifiedHyCoinDTO()
                {
                    NewValue = newValue
                });
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [RequiredRole("Admin")]
        [ExceptionHandler]
        [HttpPost("RemoveHyCoin", Name = "removeHyCoin")]
        [ProducesResponseType(typeof(ModifiedKreditDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> RemoveHyCoin([FromBody] HyCoinTransactionDTO hyCoinTransactionDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                var newValue = await UserService.RemoveHyCoinAsync(hyCoinTransactionDTO);

                return Ok(new ModifiedHyCoinDTO()
                {
                    NewValue = newValue
                });
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [RequiredRole("Admin")]
        [ExceptionHandler]
        [HttpPost("ResetHyCoin", Name = "resetHyCoin")]
        [ProducesResponseType(typeof(ModifiedKreditDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> ResetHyCoin([FromBody] HyCoinResetDTO hyCoinResetDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                var newValue = await UserService.ResetHyCoinAsync(hyCoinResetDTO.UserName);

                return Ok(new ModifiedHyCoinDTO()
                {
                    NewValue = newValue
                });
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [AllowAnonymous]
        [ExceptionHandler]
        [HttpGet("ProcessJatekFizetesCall", Name = "processJatekFizetesCall")]
        [ProducesResponseType(typeof(EmptyDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> ProcessJatekFizetesCall(
            [FromRoute] string id,
            [FromRoute] string prefix,
            [FromRoute] string message,
            [FromRoute] string to,
            [FromRoute] string from,
            [FromRoute] string tariff,
            [FromRoute] string test)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            // TODO: check if the caller id is: 79.172.252.63

            var EDSMSPurchase = _EDSMSMapper.MapToEDSMSPurchase(id, prefix, message, to, from, tariff, test);
            var addedCode = await _EDSMSService.ProcessEDSMSAsync(EDSMSPurchase);
            var isCodeValid = addedCode != null;

            var responseMessage = isCodeValid
                ? string.Format("A HyHeroes megkapta az SMS-edet. Kredit aktiváló kódod: {0}", addedCode.Code)
                : "Niba történt az SMS vásárlás során. Kérjük vedd fel velünk a kapcsolatot: info@hyheroes.hu";

            return Ok(string.Format("<reply>{0}</reply>", responseMessage));
        }

        [RequiredRole("User")]
        [ExceptionHandler]
        [HttpGet("GetEDSMSData", Name = "getEDSMSData")]
        [ProducesResponseType(typeof(EDSMSPurchaseTypeDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public IActionResult GetEDSMSsData()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var EDSMSTypes = _EDSMSService.GetEDSMSPurchaseTypes();

            return Ok(EDSMSTypes);
        }

        [RequiredRole("User")]
        [ExceptionHandler]
        [HttpPost("ApplyEDSMSKredit", Name = "applyEDSMSKredit")]
        [ProducesResponseType(typeof(EmptyDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> ApplyEDSMSKredit([FromBody] ApplyKreditDTO applyKreditDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var isApplied = await _EDSMSService.ApplyKreditAsync(applyKreditDTO);
            if (!isApplied)
            {
                throw new Exception();
            }

            return Ok(new EmptyDTO());
        }

        [RequiredRole("User")]
        [ExceptionHandler]
        [HttpPost("StartPayPalTransaction", Name = "startPayPalTransaction")]
        [ProducesResponseType(typeof(PayPalTransactionDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> StartPayPalTransaction()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var transaction = await _payPalService.CreatePayPalTransaction(User.FindFirstValue(ClaimTypes.Name));

            return Ok(transaction);
        }

        [AllowAnonymous]
        [ExceptionHandler]
        [HttpPost("PayPalIPN", Name = "payPalIPN")]
        [ProducesResponseType(typeof(EmptyDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public IActionResult ProcessPayPalIPN(/*[FromBody] PayPalIPNMessageDTO payPalIPNMessageDTO*/
            //string mc_gross,
            //string protection_eligibility,
            //string address_status,
            //string payer_id,
            //string tax,
            //string address_street,
            //string payment_date,
            //string payment_status,
            //string charset,
            //string address_zip,
            //string first_name,
            //string mc_fee,
            //string address_country_code,
            //string address_name,
            //string notify_version,
            //[FromRoute]string tax
            //string payer_status,
            //string address_country,
            //string address_city,
            //string quantity,
            //string verify_sign,
            //string payer_email,
            //string txn_id,
            //string payment_type,
            //string last_name,
            //string address_state,
            //string receiver_email,
            //string payment_fee,
            //string receiver_id,
            //string item_name,
            //string mc_currency,
            //string item_number,
            //string residence_country,
            //string test_ipn,
            //string handling_amount,
            //string transaction_subject,
            //string payment_gross,
            //string shipping)
            )
        {
            // https://ipnpb.sandbox.paypal.com/cgi-bin/webscr


            //var payPalIPNMessage = _payPalMapper.MapToIPNMessage(
            //    mc_gross,
            //    protection_eligibility,
            //    address_status,
            //    payer_id,
            //    tax,
            //    address_street,
            //    payment_date,
            //    payment_status,
            //    charset,
            //    address_zip,
            //    first_name,
            //    mc_fee,
            //    address_country_code,
            //    address_name,
            //    notify_version,
            //    custom,
            //    payer_status,
            //    address_country,
            //    address_city,
            //    quantity,
            //    verify_sign,
            //    payer_email,
            //    txn_id,
            //    payment_type,
            //    last_name,
            //    address_state,
            //    receiver_email,
            //    payment_fee,
            //    receiver_id,
            //    item_name,
            //    mc_currency,
            //    item_number,
            //    residence_country,
            //    test_ipn,
            //    handling_amount,
            //    transaction_subject,
            //    payment_gross,
            //    shipping);

            return Ok();
        }
    }
}
