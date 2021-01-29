using System;
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

        private readonly IMassKreditActivationService _massKreditActivationService;

        private readonly IEDSMSMapper _EDSMSMapper;
        private readonly IPayPalMapper _payPalMapper;

        public CurrencyController(
            IUserService userService,
            IAuthorizerService authorizerService,
            IEDSMSService EDSMSService,
            IPayPalService payPalService,
            IMassKreditActivationService massKreditActivationService,
            IEDSMSMapper EDSMSMapper,
            IPayPalMapper payPalMapper,
            IIPValidatorService IPValidatorService,
            ICustomAntiforgeryService customAntiforgeryService,
            IBarionPaymentService barionPaymentService,
            IOptions<AppSettings> appSettings)
            : base(userService, authorizerService, IPValidatorService, customAntiforgeryService, appSettings)
        {
            _EDSMSService = EDSMSService ?? throw new ArgumentException(nameof(EDSMSService));
            _payPalService = payPalService ?? throw new ArgumentException(nameof(payPalService));
            _barionPaymentService = barionPaymentService ?? throw new ArgumentException(nameof(barionPaymentService));
            _massKreditActivationService = massKreditActivationService 
                ?? throw new ArgumentException(nameof(massKreditActivationService));

            _EDSMSMapper = EDSMSMapper ?? throw new ArgumentException(nameof(EDSMSMapper));
            _payPalMapper = payPalMapper ?? throw new ArgumentException(nameof(payPalMapper));
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
        [ProducesResponseType(typeof(EmptyDTO), 200)]
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
                await _massKreditActivationService.ActivateMassKreditCodeAsync(
                    massKreditCodeActivationDTO,
                    User.FindFirstValue(ClaimTypes.Name));

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

        [Obsolete]
        [AllowAnonymous]
        [HttpGet("ProcessJatekFizetesCall", Name = "processJatekFizetesCall")]
        [ProducesResponseType(typeof(EmptyDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> ProcessJatekFizetesCall(
            string id,
            string prefix,
            string message,
            string to,
            string from,
            string tariff,
            string test)
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
                var appliedEDSMSKredit = await _EDSMSService.ApplyJatekFizetesCallAsync(applyKreditDTO);

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
        [ProducesResponseType(typeof(EmptyDTO), 200)]
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
                return Ok(await _barionPaymentService.InitializeTransactionAsync(paymentTransactionDTO));
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
    }
}
