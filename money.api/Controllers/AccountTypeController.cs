using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using money.core;
using money.core.Features.AccountType.Queries.GetAllAccountTypes;
using money.core.Services.Interfaces;
using money.domain.Entities;
using System.Net;

namespace money.api.Controllers
{
    [Route("api/Accounttype")]
    [ApiController]
    public class AccountTypeController : ControllerBase
    {
        private readonly ILogger<AccountTypeController> _logger;
        protected Response _response;
        private readonly IAccountTypeServiceAsync _dbAccountTypeService;
        private readonly IMapper _mapper;

        public AccountTypeController(ILogger<AccountTypeController> logger, IAccountTypeServiceAsync dbAccountTypeService, IMapper mapper)
        {
            _logger = logger;
            _dbAccountTypeService = dbAccountTypeService;
            _mapper = mapper;
            _response = new Response();
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<Response>> GetAccountType()
        {
            try
            {
                IEnumerable<AccountTypeMaster> accountTypeList;
                accountTypeList = await _dbAccountTypeService.GetAllAsync();
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
    }
}
