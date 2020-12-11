using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using mktSolution.Application.SCM.Product;

namespace mktSolution.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class SCM_ProductController : ControllerBase
    {
        private readonly I_SCM_PublicProductService _i_SCM_PublicProductService;
        public SCM_ProductController(I_SCM_PublicProductService i_SCM_PublicProductService)
        {
            _i_SCM_PublicProductService = i_SCM_PublicProductService;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var product = await _i_SCM_PublicProductService.GetAll();
            return Ok(product);
        }
    }
}
