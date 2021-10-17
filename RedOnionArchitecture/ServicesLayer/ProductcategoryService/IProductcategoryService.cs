using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLayer.ProductcategoryService
{
    public interface IProductcategoryService
    {
        IEnumerable<ProductCategory> GetAllProductCategory();
        ProductCategory GetProductCategoryById(int id);
        void CreateNewProductCategory(ProductCategory productCategory);
        void UpdateProductCategory(ProductCategory productCategory);
        void DeleteProductCategory(int id);
    }
}
