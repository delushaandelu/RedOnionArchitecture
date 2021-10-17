using DomainLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicesLayer.ProductcategoryService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCostApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductcategoryController : ControllerBase
    {
        private readonly IProductcategoryService _productcategoryService;

        public ProductcategoryController(IProductcategoryService productcategoryService)
        {
            _productcategoryService = productcategoryService;
        }

        [HttpPost(nameof(GetProductCategoryById))]
        public IActionResult GetProductCategoryById(int id)
        {
            var result = _productcategoryService.GetProductCategoryById(id);
            if(result is not null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest("No Record found");
            }
        }

        [HttpPost(nameof(GetAllProductCategory))]
        public IActionResult GetAllProductCategory()
        {
            var result = _productcategoryService.GetAllProductCategory();
            if (result is not null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest("No Record found");
            }
        }

        [HttpPost(nameof(CreateNewProductCategory))]
        public IActionResult CreateNewProductCategory(ProductCategory productCategory)
        {
            _productcategoryService.CreateNewProductCategory(productCategory);
            return Ok("Data Created");
        }

        [HttpPost(nameof(UpdateProductCategory))]
        public IActionResult UpdateProductCategory(ProductCategory productCategory)
        {
            _productcategoryService.UpdateProductCategory(productCategory);
            return Ok("Data Updated");
        }

        [HttpPost(nameof(DeleteProductCategory))]
        public IActionResult DeleteProductCategory(int id)
        {
            _productcategoryService.DeleteProductCategory(id);
            return Ok("Data Deleted");
        }
    }
}
