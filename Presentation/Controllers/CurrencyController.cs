using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Threading.Tasks;
using HyHeroesWebAPI.Infrastructure.Infrastructure.Services.Interfaces;
using HyHeroesWebAPI.Presentation.ConfigObjects;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.Filters;
using HyHeroesWebAPI.Presentation.Mapper;
using HyHeroesWebAPI.Presentation.Mapper.Interfaces;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace HyHeroesWebAPI.Presentation.Controllers
{
    [Route("[controller]")]
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

        [ValidateIP]
        [ValidateCustomAntiforgery]
        [RequiredRole("Admin")]
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

        [ValidateIP]
        [ValidateCustomAntiforgery]
        [RequiredRole("Admin")]
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

        [ValidateIP]
        [ValidateCustomAntiforgery]
        [RequiredRole("Admin")]
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

        [ValidateIP]
        [ValidateCustomAntiforgery]
        [RequiredRole("Admin")]
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

        [ValidateIP]
        [ValidateCustomAntiforgery]
        [RequiredRole("Admin")]
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

        [ValidateIP]
        [ValidateCustomAntiforgery]
        [RequiredRole("User")]
        [HttpPost("ActivateMassKreditCode", Name = "activateMassKreditCode")]
        [ProducesResponseType(typeof(AppliedEDSMSKreditDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> ActivateMassKreditCodeAsync(
            [FromBody] MassKreditCodeActivationDTO massKreditCodeActivationDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                var addedKredit = await _massKreditActivationService.ActivateMassKreditCodeAsync(
                    massKreditCodeActivationDTO,
                    User.FindFirstValue(ClaimTypes.Name));

                return Ok(new AppliedEDSMSKreditDTO()
                { 
                    KreditValue = addedKredit
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
        [HttpPost("AddMassKreditCode", Name = "addMassKreditCode")]
        [ProducesResponseType(typeof(MassKreditCodeDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> AddMassKreditCodeAsync(
            [FromBody] NewMassKreditCodeDTO newMassKreditCodeDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                var createdMassKreditCodeDTO = await _massKreditActivationService
                    .AddMassKreditCodeAsync(newMassKreditCodeDTO);

                return Ok(createdMassKreditCodeDTO);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [ValidateIP]
        [ValidateCustomAntiforgery]
        [RequiredRole("Admin")]
        [HttpPost("RemoveMassKreditCode", Name = "removeMassKreditCode")]
        [ProducesResponseType(typeof(EmptyDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
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
        [HttpPost("GetAllActiveMassKreditCodes", Name = "getAllActiveMassKreditCodes")]
        [ProducesResponseType(typeof(ActiveMassKreditCodesDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetAllActiveMassKreditCodesAsync()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                var activeCodes = await _massKreditActivationService.GetAllActiveMassKreditCodesAsync();

                return Ok(activeCodes);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [ValidateIP]
        [ValidateCustomAntiforgery]
        [RequiredRole("User")]
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

            try
            {
                var EDSMSTypes = _EDSMSService.GetEDSMSPurchaseTypes();

                return Ok(EDSMSTypes);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [ValidateIP]
        [ValidateCustomAntiforgery]
        [RequiredRole("User")]
        [HttpPost("ApplyEDSMSKredit", Name = "applyEDSMSKredit")]
        [ProducesResponseType(typeof(AppliedEDSMSKreditDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
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

                if (appliedEDSMSKredit == null)
                {
                    throw new Exception();
                }

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

            try
            {
                var transaction = await _payPalService.CreatePayPalTransaction(User.FindFirstValue(ClaimTypes.Name));

                return Ok(transaction);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [AllowAnonymous]
        [HttpPost("PayPalIPN", Name = "payPalIPN")]
        [ProducesResponseType(typeof(EmptyDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
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
        [HttpPost("InitializeBarionTransaction", Name = "initializeBarionTransaction")]
        [ProducesResponseType(typeof(InitializedBarionTransactionDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
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
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> CallbackBarionPaymentAsync(
            [FromBody] BarionCallbackDTO barionCallbackDTO)
            //[FromBody] string paymentId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                // INFO: https://docs.barion.com/Callback_mechanism
                await _barionPaymentService.ProcessBarionCallbackAsync(barionCallbackDTO);
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
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
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
        [HttpGet("CheckBarionPaymentId/{paymentId}", Name = "checkBarionPaymentId")]
        [ProducesResponseType(typeof(BarionTransactionStateDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
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
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
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
        [HttpPost("StartBankTransferKreditPurchase", Name = "startBankTransferKreditPurchase")]
        [ProducesResponseType(typeof(StartedBankTransferDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
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
        [HttpPost("ApplyBankTransfer", Name = "applyBankTransfer")]
        [ProducesResponseType(typeof(EmptyDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> ApplyBankTransferAsync(
            [Required][FromBody] ApplyBankTransferDTO applyBankTransferDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                await _bankTransferService.ApplyBankTransferAsync(applyBankTransferDTO.TransferCode);
                return Ok(new EmptyDTO());
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
