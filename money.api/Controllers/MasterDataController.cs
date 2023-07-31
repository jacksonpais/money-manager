using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using money.core;
using money.core.Features.AccountType.Queries.GetAllAccountTypes;
using money.core.Features.Category.Queries.GetAllCategories;
using money.core.Features.Currency.Queries.GetAllCurrencies;
using money.core.Features.PaymentMode.Queries.GetAllPaymentModes;
using money.core.Features.TransactionType.Queries.GetAllTransactionTypes;
using money.core.Services.Interfaces;
using money.domain.Entities;
using System.Net;

namespace money.api.Controllers
{
    [Route("api/masterdata")]
    [ApiController]
    public class MasterDataController : ControllerBase
    {
        private readonly ILogger<MasterDataController> _logger;
        protected Response _response;
        private readonly IAccountTypeServiceAsync _accountTypeService;
        private readonly ICategoryServiceAsync _categoryService;
        private readonly ICurrencyServiceAsync _currencyService;
        private readonly IPaymentModeServiceAsync _paymentModeService;
        private readonly ITransactionTypeServiceAsync _transactionTypeService;
        private readonly IMapper _mapper;

        public MasterDataController(ILogger<MasterDataController> logger, IAccountTypeServiceAsync accountService, ICategoryServiceAsync categoryService, ICurrencyServiceAsync currencyService, IPaymentModeServiceAsync paymentModeService, ITransactionTypeServiceAsync transactionTypeService, IMapper mapper)
        {
            _logger = logger;
            _accountTypeService = accountService;
            _categoryService = categoryService;
            _currencyService = currencyService;
            _paymentModeService = paymentModeService;
            _transactionTypeService = transactionTypeService;
            _mapper = mapper;
            _response = new Response();
        }

        [HttpGet]
        [Route("account")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<Response>> GetAccountType()
        {
            try
            {
                IEnumerable<AccountTypeMaster> accountTypeList;
                accountTypeList = await _accountTypeService.GetAllAsync();
                _response.Result = _mapper.Map<List<AllAccountTypesViewModel>>(accountTypeList);
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

        [HttpGet]
        [Route("category")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<Response>> GetCategory()
        {
            try
            {
                IEnumerable<CategoryMaster> categoryList;
                categoryList = await _categoryService.GetAllAsync();
                _response.Result = _mapper.Map<List<AllCategoryViewModel>>(categoryList);
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

        [HttpGet]
        [Route("currency")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<Response>> GetCurrency()
        {
            try
            {
                IEnumerable<CurrencyMaster> currencyList;
                currencyList = await _currencyService.GetAllAsync();
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

        [HttpGet]
        [Route("paymentmode")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<Response>> GetPaymentMode()
        {
            try
            {
                IEnumerable<PaymentModesMaster> transactionTypeList;
                transactionTypeList = await _paymentModeService.GetAllAsync();
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

        [HttpGet]
        [Route("transactiontype")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<Response>> GetTransactionType()
        {
            try
            {
                IEnumerable<TransactionTypeMaster> transactionTypeList;
                transactionTypeList = await _transactionTypeService.GetAllAsync();
                _response.Result = _mapper.Map<List<AllTransactionTypesViewModel>>(transactionTypeList);
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
