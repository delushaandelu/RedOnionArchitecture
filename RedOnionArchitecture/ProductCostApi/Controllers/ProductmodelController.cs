using DomainLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicesLayer.ProductmodelService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCostApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductmodelController : ControllerBase
    {
        private readonly IProductmodelService  _productmodelService;

        public ProductmodelController(IProductmodelService productmodelService)
        {
            _productmodelService = productmodelService;
        }

        [HttpPost(nameof(GetProductModel))]
        public IActionResult GetProductModel(int id)
        {
            var result = _productmodelService.GetProductModel(id);
            if (result is not null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(new { message = "bad request" });
            }
        }

        [HttpPost(nameof(GetAllProductModels))]
        public IActionResult GetAllProductModels()
        {
            var result = _productmodelService.GetAllProductModels();
            if (result is not null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(new { message = "bad request" });
            }
        }

        [HttpPost(nameof(GetAllProductModelsByProductSeries))]
        public IActionResult GetAllProductModelsByProductSeries(int productSeries)
        {
            var result = _productmodelService.GetAllProductModelsByProductSeries(productSeries);
            if (result is not null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(new { message = "bad request" });
            }
        }

        [HttpPost(nameof(CreateNewProductModel))]
        public IActionResult CreateNewProductModel(ProductModel productModel)
        {
            _productmodelService.CreateNewProductModel(productModel);
            return Ok(new { message = "Data Created" });
        }

        [HttpPost(nameof(UpdateProductModel))]
        public IActionResult UpdateProductModel(ProductModel productModel)
        {
            _productmodelService.UpdateProductModel(productModel);
            return Ok(new { message = "Data Updated" });
        }

        [HttpPost(nameof(DeleteProductModel))]
        public IActionResult DeleteProductModel(int id)
        {
            _productmodelService.DeleteProductModel(id);
            return Ok(new { message = "Data Deleted" });
        }

    }
}
