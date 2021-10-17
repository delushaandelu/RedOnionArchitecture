using DomainLayer.Models;
using RepositoryLayer.Repositroy.ProductModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLayer.ProductmodelService
{
    public class ProductmodelService : IProductmodelService
    {
        private IProductmodelRepository<ProductModel> _productmodelRepository;

        public ProductmodelService(IProductmodelRepository<ProductModel> productmodelRepository)
        {
            _productmodelRepository = productmodelRepository;
        }

        public void CreateNewProductModel(ProductModel productModel)
        {
            _productmodelRepository.Insert(productModel);
        }

        public void DeleteProductModel(int id)
        {
            ProductModel productModel = GetProductModel(id);
            _productmodelRepository.Remove(productModel);
            _productmodelRepository.SaveChanges();
        }

        public IEnumerable<ProductModel> GetAllProductModels()
        {
            return _productmodelRepository.GetAll();
        }

        public IEnumerable<ProductModel> GetAllProductModelsByProductSeries(int productSeries)
        {
            return _productmodelRepository.GetAll().Where(x => x.ProductSeriesId == productSeries);
        }

        public ProductModel GetProductModel(int id)
        {
            return _productmodelRepository.GetById(id);
        }

        public void UpdateProductModel(ProductModel productModel)
        {
            _productmodelRepository.Update(productModel);
        }
    }
}
