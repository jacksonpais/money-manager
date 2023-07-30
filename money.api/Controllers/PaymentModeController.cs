using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using money.core;
using money.core.Features.PaymentMode.Queries.GetAllPaymentModes;
using money.core.Services.Interfaces;
using money.domain.Entities;
using System.Net;

namespace money.api.Controllers
{
    [Route("api/paymentmode")]
    [ApiController]
    public class PaymentModeController : ControllerBase
    {
        private readonly ILogger<PaymentModeController> _logger;
        protected Response _response;
        private readonly IPaymentModeServiceAsync _dbPaymentModeService;
        private readonly IMapper _mapper;

        public PaymentModeController(ILogger<PaymentModeController> logger, IPaymentModeServiceAsync dbPaymentModeService, IMapper mapper)
        {
            _logger = logger;
            _dbPaymentModeService = dbPaymentModeService;
            _mapper = mapper;
            _response = new Response();
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<Response>> GetPaymentMode()
        {
            try
            {
                IEnumerable<PaymentModesMaster> transactionTypeList;
                transactionTypeList = await _dbPaymentModeService.GetAllAsync();
                _response.Result = _mapper.Map<List<AllPaymentModeViewModel>>(transactionTypeList);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages
                     = new List<string>() { ex.ToString() };
            }
            return _response;
        }
    }
}
