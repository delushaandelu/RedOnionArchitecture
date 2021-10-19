using DomainLayer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicesLayer.ProductPart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Cors;

namespace ProductCostApi.Controllers
{
    [EnableCorsAttribute("*", "*", "*")]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductpartController : ControllerBase
    {
        private readonly IProductPartService _productPartService;

        public ProductpartController(IProductPartService productPartService)
        {
            _productPartService = productPartService;
        }

        [HttpPost(nameof(GetProductPart))]
        public IActionResult GetProductPart(int id)
        {
            var result = _productPartService.GetProductPart(id);
            if (result is not null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(new { message = "bad request" });
            }
        }

        [HttpPost(nameof(GetAllProductParts))]
        public IActionResult GetAllProductParts()
        {
            var result = _productPartService.GetAllProductParts();
            if (result is not null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(new { message = "bad request" });
            }
        }

        [HttpPost(nameof(GetAllProductPartsByProductModel))]
        public IActionResult GetAllProductPartsByProductModel(int productSeries)
        {
            var result = _productPartService.GetAllProductPartsByProductModel(productSeries);
            if (result is not null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(new { message = "bad request" });
            }
        }

        [Authorize]
        [HttpPost(nameof(CreateNewProductPart))]
        public IActionResult CreateNewProductPart(ProductPart productPart)
        {
            _productPartService.CreateNewProductPart(productPart);
            return Ok(new { message = "Data Created" });
        }

        [Authorize]
        [HttpPost(nameof(UpdateProductPart))]
        public IActionResult UpdateProductPart(ProductPart productPart)
        {
            _productPartService.UpdateProductPart(productPart);
            return Ok(new { message = "Data Updated" });
        }

        [Authorize]
        [HttpPost(nameof(DeleteProductPart))]
        public IActionResult DeleteProductPart(int id)
        {
            _productPartService.DeleteProductPart(id);
            return Ok(new { message = "Data Deleted" });
        }
    }
}
