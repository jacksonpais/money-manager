using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using money.core;
using money.core.Features.Category.Queries.GetAllCategories;
using money.core.Services.Interfaces;
using money.domain.Entities;
using System.Net;

namespace money.api.Controllers
{
    [Route("api/category")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ILogger<CategoryController> _logger;
        protected Response _response;
        private readonly ICategoryServiceAsync _dbCategoryService;
        private readonly IMapper _mapper;

        public CategoryController(ILogger<CategoryController> logger, ICategoryServiceAsync dbCategoryService, IMapper mapper)
        {
            _logger = logger;
            _dbCategoryService = dbCategoryService;
            _mapper = mapper;
            _response = new Response();
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<Response>> GetCategory()
        {
            try
            {
                IEnumerable<CategoryMaster> categoryList;
                categoryList = await _dbCategoryService.GetAllAsync();
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
    }
}
