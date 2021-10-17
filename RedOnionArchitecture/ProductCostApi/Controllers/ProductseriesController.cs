using DomainLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicesLayer.ProductseriesService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCostApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductseriesController : ControllerBase
    {
        private readonly IProductseriesService _productseriesService;

        public ProductseriesController(IProductseriesService productseriesService)
        {
            _productseriesService = productseriesService;
        }

        [HttpPost(nameof(GetProductSeries))]
        public IActionResult GetProductSeries(int id)
        {
            var result = _productseriesService.GetProductSeries(id);
            if(result is not null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(new { message = "bad request" });
            }
        }

        [HttpPost(nameof(GetAllProductSeries))]
        public IActionResult GetAllProductSeries()
        {
            var result = _productseriesService.GetAllProductSeries();
            if (result is not null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(new { message = "bad request" });
            }
        }

        [HttpPost(nameof(GetAllProductSeriesByProductCategory))]
        public IActionResult GetAllProductSeriesByProductCategory(int productCategory)
        {
            var result = _productseriesService.GetAllProductSeriesByProductCategory(productCategory);
            if (result is not null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(new { message = "bad request" });
            }
        }

        [HttpPost(nameof(CreateNewProductSeries))]
        public IActionResult CreateNewProductSeries(ProductSeries productSeries)
        {
            _productseriesService.CreateNewProductSeries(productSeries);
            return Ok(new { message = "Data Created" });
        }

        [HttpPost(nameof(UpdateProductSeries))]
        public IActionResult UpdateProductSeries(ProductSeries productSeries)
        {
            _productseriesService.UpdateProductSeries(productSeries);
            return Ok(new { message = "Data Updated" });
        }

        [HttpPost(nameof(DeleteProductSeries))]
        public IActionResult DeleteProductSeries(int id)
        {
            _productseriesService.DeleteProductSeries(id);
            return Ok(new { message = "Data Deleted" });
        }
    }
}
