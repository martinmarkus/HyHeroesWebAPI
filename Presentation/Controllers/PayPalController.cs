using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HyHeroesWebAPI.Presentation.DTOs;
using HyHeroesWebAPI.Presentation.DTOs.PayPalDTOs;
using HyHeroesWebAPI.Presentation.Filters;
using HyHeroesWebAPI.Presentation.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HyHeroesWebAPI.Presentation.Controllers
{
    [Route("[controller]")]
    public class PayPalController : ControllerBase
    {
        private readonly IPayPalService _payPalService;

        public PayPalController(IPayPalService payPalService)
        {
            _payPalService = payPalService ?? throw new ArgumentException(nameof(payPalService));
        }

        [AllowAnonymous]
        [ExceptionHandler]
        [HttpPost("IPN", Name = "ipn")]
        [ProducesResponseType(typeof(EmptyDTO), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> ProcessIPN(PayPalIPNDTO payPalIPNDTO)
        {
            var isProcessed = await _payPalService.ProcessIPNAsync(payPalIPNDTO);

            if (!isProcessed)
            {
                return BadRequest();
            }

            return Ok();
        }      
    } 
}
