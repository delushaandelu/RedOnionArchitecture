using DomainLayer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicesLayer.ProductcategoryService;
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
                return BadRequest(new { message = "bad request" });
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
                return BadRequest(new { message = "bad request" });
            }
        }

        [Authorize]
        [HttpPost(nameof(CreateNewProductCategory))]
        public IActionResult CreateNewProductCategory(ProductCategory productCategory)
        {
            _productcategoryService.CreateNewProductCategory(productCategory);
            return Ok(new { message = "Data Created" });
        }

        [Authorize]
        [HttpPost(nameof(UpdateProductCategory))]
        public IActionResult UpdateProductCategory(ProductCategory productCategory)
        {
            _productcategoryService.UpdateProductCategory(productCategory);
            return Ok(new { message = "Data Updated" });
        }

        [Authorize]
        [HttpPost(nameof(DeleteProductCategory))]
        public IActionResult DeleteProductCategory(int id)
        {
            _productcategoryService.DeleteProductCategory(id);
            return Ok(new { message = "Data Deleted" });
        }
    }
}
