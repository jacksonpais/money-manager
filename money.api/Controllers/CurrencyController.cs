using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using money.core;
using money.core.Features.Currency.Queries.GetAllCurrencies;
using money.core.Services.Interfaces;
using money.domain.Entities;
using System.Net;

namespace money.api.Controllers
{
    [Route("api/currency")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        private readonly ILogger<CurrencyController> _logger;
        protected Response _response;
        private readonly ICurrencyServiceAsync _dbCurrencyService;
        private readonly IMapper _mapper;

        public CurrencyController(ILogger<CurrencyController> logger, ICurrencyServiceAsync dbCurrencyService, IMapper mapper)
        {
            _logger = logger;
            _dbCurrencyService = dbCurrencyService;
            _mapper = mapper;
            _response = new Response();
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<Response>> GetCurrency()
        {
            try
            {
                IEnumerable<CurrencyMaster> currencyList;
                currencyList = await _dbCurrencyService.GetAllAsync();
                _response.Result = _mapper.Map<List<AllCurrencyViewModel>>(currencyList);
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
