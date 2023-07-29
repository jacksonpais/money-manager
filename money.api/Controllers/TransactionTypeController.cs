using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using money.core;
using money.core.Features.TransactionType.Queries.GetAllTransactionTypes;
using money.core.Services.Interfaces;
using money.domain.Entities;
using System.Net;

namespace money.api.Controllers
{
    [Route("api/transactiontype")]
    [ApiController]
    public class TransactionTypeController : ControllerBase
    {
        private readonly ILogger<TransactionTypeController> _logger;
        protected Response _response;
        private readonly ITransactionTypeServiceAsync _dbTransactionTypeService;
        private readonly IMapper _mapper;

        public TransactionTypeController(ILogger<TransactionTypeController> logger, ITransactionTypeServiceAsync dbTransactionTypeService, IMapper mapper)
        {
            _logger = logger;
            _dbTransactionTypeService = dbTransactionTypeService;
            _mapper = mapper;
            _response = new Response();
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<Response>> GetTransactionType()
        {
            try
            {
                IEnumerable<TransactionTypeMaster> transactionTypeList;
                transactionTypeList = await _dbTransactionTypeService.GetAllAsync();
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
