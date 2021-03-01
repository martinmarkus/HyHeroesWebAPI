using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Threading.Tasks;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Services.Interfaces;
using HyHeroesWebAPI.Infrastructure.Infrastructure.ConfigObjects;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Filters;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace HyHeroesWebAPI.Presentation.Controllers
{
    [ServiceFilter(typeof(Logger))]
    [Route("API/Currency")]
    public class CurrencyController : AuthorizableBaseController
    {
        private readonly IEDSMSService _EDSMSService;
        private readonly IPayPalService _payPalService;
        private readonly IBarionPaymentService _barionPaymentService;
        private readonly IBankTransferService _bankTransferService;
        private readonly IMassKreditActivationService _massKreditActivationService;

        public CurrencyController(
            IUserService userService,
            IAuthorizerService authorizerService,
            IEDSMSService EDSMSService,
            IPayPalService payPalService,
            IMassKreditActivationService massKreditActivationService,
            IIPValidatorService IPValidatorService,
            ICustomAntiforgeryService customAntiforgeryService,
            IBarionPaymentService barionPaymentService,
            IBankTransferService bankTransferService,
            IOptions<AppSettings> appSettings)
            : base(userService, authorizerService, IPValidatorService, customAntiforgeryService, appSettings)
        {
            _bankTransferService = bankTransferService ?? throw new ArgumentException(nameof(bankTransferService));
            _EDSMSService = EDSMSService ?? throw new ArgumentException(nameof(EDSMSService));
            _payPalService = payPalService ?? throw new ArgumentException(nameof(payPalService));
            _barionPaymentService = barionPaymentService ?? throw new ArgumentException(nameof(barionPaymentService));
            _massKreditActivationService = massKreditActivationService 
                ?? throw new ArgumentException(nameof(massKreditActivationService));
        }

        [ValidateIP]
        [ValidateCustomAntiforgery]
        [RequiredRole("Admin")]
        [ServiceFilter(typeof(SessionRefresh))]
        [HttpPost("AddKredit", Name = "addKredit")]
        [ProducesResponseType(typeof(ModifiedKreditDTO), 200)]
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

        [ValidateIP]
        [ValidateCustomAntiforgery]
        [RequiredRole("Admin")]
        [ServiceFilter(typeof(SessionRefresh))]
        [HttpPost("RemoveKredit", Name = "removeKredit")]
        [ProducesResponseType(typeof(ModifiedKreditDTO), 200)]
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

        [ValidateIP]
        [ValidateCustomAntiforgery]
        [RequiredRole("Admin")]
        [ServiceFilter(typeof(SessionRefresh))]
        [HttpPost("ResetKredit", Name = "resetKredit")]
        [ProducesResponseType(typeof(ModifiedKreditDTO), 200)]
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

        [AllowAnonymous]
        [ServiceFilter(typeof(GameServerIntegration))]
        [HttpPost("AddHyCoin", Name = "addHyCoin")]
        [ProducesResponseType(typeof(ModifiedKreditDTO), 200)]
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

        [AllowAnonymous]
        [ServiceFilter(typeof(GameServerIntegration))]
        [HttpPost("RemoveHyCoin", Name = "removeHyCoin")]
        [ProducesResponseType(typeof(ModifiedKreditDTO), 200)]
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

        [AllowAnonymous]
        [ServiceFilter(typeof(GameServerIntegration))]
        [HttpPost("ResetHyCoin", Name = "resetHyCoin")]
        [ProducesResponseType(typeof(ModifiedKreditDTO), 200)]
        public async Task<IActionResult> ResetHyCoin([FromBody] HyCoinResetDTO hyCoinResetDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                return Ok(new ModifiedHyCoinDTO()
                {
                    NewValue = await UserService.ResetHyCoinAsync(hyCoinResetDTO.UserName)
                });
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [ValidateIP]
        [ValidateCustomAntiforgery]
        [RequiredRole("User")]
        [ServiceFilter(typeof(SessionRefresh))]
        [HttpPost("ActivateMassKreditCode", Name = "activateMassKreditCode")]
        [ProducesResponseType(typeof(AppliedEDSMSKreditDTO), 200)]
        public async Task<IActionResult> ActivateMassKreditCodeAsync(
            [FromBody] MassKreditCodeActivationDTO massKreditCodeActivationDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                return Ok(new AppliedEDSMSKreditDTO()
                { 
                    KreditValue = await _massKreditActivationService.ActivateMassKreditCodeAsync(
                        massKreditCodeActivationDTO,
                        User.FindFirstValue(ClaimTypes.Name))
                });
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [ValidateIP]
        [ValidateCustomAntiforgery]
        [RequiredRole("Admin")]
        [ServiceFilter(typeof(SessionRefresh))]
        [HttpPost("AddMassKreditCode", Name = "addMassKreditCode")]
        [ProducesResponseType(typeof(MassKreditCodeDTO), 200)]
        public async Task<IActionResult> AddMassKreditCodeAsync(
            [FromBody] NewMassKreditCodeDTO newMassKreditCodeDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                return Ok(await _massKreditActivationService
                    .AddMassKreditCodeAsync(newMassKreditCodeDTO));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [ValidateIP]
        [ValidateCustomAntiforgery]
        [RequiredRole("Admin")]
        [ServiceFilter(typeof(SessionRefresh))]
        [HttpPost("RemoveMassKreditCode", Name = "removeMassKreditCode")]
        [ProducesResponseType(typeof(EmptyDTO), 200)]
        public async Task<IActionResult> RemoveMassKreditCodeAsync(
            [FromBody] RemoveMassKreditCodeDTO removeMassKreditCodeDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                await _massKreditActivationService
                    .RemoveMassKreditCodeAsync(removeMassKreditCodeDTO);

                return Ok(new EmptyDTO());
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [ValidateIP]
        [ValidateCustomAntiforgery]
        [RequiredRole("Admin")]
        [ServiceFilter(typeof(SessionRefresh))]
        [HttpPost("GetAllActiveMassKreditCodes", Name = "getAllActiveMassKreditCodes")]
        [ProducesResponseType(typeof(ActiveMassKreditCodesDTO), 200)]
        public async Task<IActionResult> GetAllActiveMassKreditCodesAsync()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                return Ok(await _massKreditActivationService.GetAllActiveMassKreditCodesAsync());
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [ValidateIP]
        [ValidateCustomAntiforgery]
        [RequiredRole("User")]
        [ServiceFilter(typeof(SessionRefresh))]
        [HttpGet("GetEDSMSData", Name = "getEDSMSData")]
        [ProducesResponseType(typeof(EDSMSPurchaseTypeDTO), 200)]
        public IActionResult GetEDSMSsData()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                return Ok(_EDSMSService.GetEDSMSPurchaseTypes());
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [ValidateIP]
        [ValidateCustomAntiforgery]
        [RequiredRole("User")]
        [ServiceFilter(typeof(SessionRefresh))]
        [HttpPost("ApplyEDSMSKredit", Name = "applyEDSMSKredit")]
        [ProducesResponseType(typeof(AppliedEDSMSKreditDTO), 200)]
        public async Task<IActionResult> ApplyEDSMSKredit([FromBody] ApplyKreditDTO applyKreditDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                var appliedEDSMSKredit = await _EDSMSService.ApplyJatekFizetesCallAsync(
                    applyKreditDTO,
                    HttpContext.Connection.RemoteIpAddress.ToString());

                return Ok(appliedEDSMSKredit);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [ValidateIP]
        [ValidateCustomAntiforgery]
        [RequiredRole("User")]
        [ServiceFilter(typeof(SessionRefresh))]
        [HttpPost("StartPayPalTransaction", Name = "startPayPalTransaction")]
        [ProducesResponseType(typeof(PayPalTransactionDTO), 200)]
        public async Task<IActionResult> StartPayPalTransaction()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                return Ok(await _payPalService.CreatePayPalTransaction(User.FindFirstValue(ClaimTypes.Name)));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [AllowAnonymous]
        [HttpPost("PayPalIPN", Name = "payPalIPN")]
        [ProducesResponseType(typeof(EmptyDTO), 200)]
        public async Task<IActionResult> ProcessPayPalIPNAsync()
        {
            // https://ipnpb.sandbox.paypal.com/cgi-bin/webscr
            if (Request == null)
            {
                return BadRequest();
            }

            var isProcessed = await _payPalService.ProcessIPNStreamAsync(Request.Body);
            if (isProcessed)
            {
                return Ok();
            }

            return BadRequest();
        }

        [ValidateIP]
        [ValidateCustomAntiforgery]
        [RequiredRole("User")]
        [ServiceFilter(typeof(SessionRefresh))]
        [HttpPost("InitializeBarionTransaction", Name = "initializeBarionTransaction")]
        [ProducesResponseType(typeof(InitializedBarionTransactionDTO), 200)]
        public async Task<IActionResult> InitializeBarionTransactionAsync(
            [FromBody] BarionPaymentTransactionDTO paymentTransactionDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                return Ok(await _barionPaymentService.InitializeTransactionAsync(
                    User.FindFirstValue(ClaimTypes.Name),
                    paymentTransactionDTO));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [AllowAnonymous]
        [HttpPost("CallbackBarionPayment", Name = "callbackBarionPayment")]
        [ProducesResponseType(typeof(EmptyDTO), 200)]
        public async Task<IActionResult> CallbackBarionPaymentAsync(string paymentId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                // INFO: https://docs.barion.com/Callback_mechanism
                await _barionPaymentService.ProcessBarionCallbackAsync(paymentId);
                return Ok();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [AllowAnonymous]
        [HttpGet("GetBarionPurchaseTypes", Name = "getBarionPurchaseTypes")]
        [ProducesResponseType(typeof(BarionPurchaseTypeListDTO), 200)]
        public IActionResult GetBarionPurchaseTypes()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                return Ok(_barionPaymentService.GetBarionPurchaseTypes());
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [ValidateIP]
        [ValidateCustomAntiforgery]
        [RequiredRole("User")]
        [ServiceFilter(typeof(SessionRefresh))]
        [HttpGet("CheckBarionPaymentId/{paymentId}", Name = "checkBarionPaymentId")]
        [ProducesResponseType(typeof(BarionTransactionStateDTO), 200)]
        public async Task<IActionResult> CheckBarionPaymentIdAsync([Required][FromRoute] string paymentId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                return Ok(await _barionPaymentService.CheckBarionPaymentIdAsync(paymentId));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [AllowAnonymous]
        [HttpGet("GetBankTransferPurchaseTypes", Name = "getBankTransferPurchaseTypes")]
        [ProducesResponseType(typeof(BankTransferTypeListDTO), 200)]
        public IActionResult GetBankTransferPurchaseTypes()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                return Ok(_bankTransferService.GetBankTransferPurchaseTypes());
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [ValidateIP]
        [ValidateCustomAntiforgery]
        [RequiredRole("User")]
        [ServiceFilter(typeof(SessionRefresh))]
        [HttpPost("StartBankTransferKreditPurchase", Name = "startBankTransferKreditPurchase")]
        [ProducesResponseType(typeof(StartedBankTransferDTO), 200)]
        public async Task<IActionResult> StartBankTransferKreditPurchaseAsync(
            [Required][FromBody] BankTransferPurchaseDTO customKreditPurchaseDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                return Ok(await _bankTransferService.StartBankTransferKreditPurchaseAsync(
                    customKreditPurchaseDTO,
                    User.FindFirstValue(ClaimTypes.Name)));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [ValidateIP]
        [ValidateCustomAntiforgery]
        [RequiredRole("Admin")]
        [ServiceFilter(typeof(SessionRefresh))]
        [HttpPost("ApplyBankTransfer", Name = "applyBankTransfer")]
        [ProducesResponseType(typeof(BankTransferDTO), 200)]
        public async Task<IActionResult> ApplyBankTransferAsync(
            [Required][FromBody] ApplyBankTransferDTO applyBankTransferDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                return Ok(await _bankTransferService.ApplyBankTransferAsync(applyBankTransferDTO.TransferCode));
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [ValidateIP]
        [ValidateCustomAntiforgery]
        [RequiredRole("User")]
        [ServiceFilter(typeof(SessionRefresh))]
        [HttpGet("GetAcceptedBillingCountries", Name = "getAcceptedBillingCountries")]
        [ProducesResponseType(typeof(AcceptedCountryListDTO), 200)]
        public IActionResult GetAcceptedBillingCountries()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                return Ok(UserService.GetAcceptedBillingCountries());
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
