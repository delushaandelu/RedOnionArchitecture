using DomainLayer.Models;
using RepositoryLayer.Repositroy.ProductCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLayer.ProductcategoryService
{
    public class ProductcategoryService : IProductcategoryService
    {
        private IProductcategoryRepository<ProductCategory> _productcategoryRepository;

        public ProductcategoryService(IProductcategoryRepository<ProductCategory> productcategoryRepository)
        {
            _productcategoryRepository = productcategoryRepository;
        }

        public void CreateNewProductCategory(ProductCategory productCategory)
        {
            _productcategoryRepository.CreateNewProductCategory(productCategory);
        }

        public void DeleteProductCategory(int id)
        {
            ProductCategory productCategory = GetProductCategoryById(id);
            _productcategoryRepository.Remove(productCategory);
            _productcategoryRepository.SaveChanges();
        }

        public IEnumerable<ProductCategory> GetAllProductCategory()
        {
            return _productcategoryRepository.GetAllProductCategory();
        }

        public ProductCategory GetProductCategoryById(int id)
        {
            return _productcategoryRepository.GetProductCategoryById(id);
        }

        public void UpdateProductCategory(ProductCategory productCategory)
        {
            _productcategoryRepository.UpdateProductCategory(productCategory);
        }
    }
}
