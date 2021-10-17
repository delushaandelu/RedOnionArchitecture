using DomainLayer.Models;
using RepositoryLayer.Repositroy.ProductSeries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLayer.ProductseriesService
{
    public class ProductseriesService : IProductseriesService
    {
        private IProductseriesRepository<ProductSeries> _productseriesRepository;

        public ProductseriesService(IProductseriesRepository<ProductSeries> productseriesRepository)
        {
            _productseriesRepository = productseriesRepository;
        }

        public void CreateNewProductSeries(ProductSeries productSeries)
        {
            _productseriesRepository.CreateNewProductSeries(productSeries);
        }

        public void DeleteProductSeries(int id)
        {
            ProductSeries productSeries = GetProductSeries(id);
            _productseriesRepository.Remove(productSeries);
            _productseriesRepository.SaveChanges();
        }

        public IEnumerable<ProductSeries> GetAllProductSeries()
        {
            return _productseriesRepository.GetAllProductSeries();
        }

        public IEnumerable<ProductSeries> GetAllProductSeriesByProductCategory(int productcategory)
        {
            return _productseriesRepository.GetAllProductSeries().Where(x => x.ProductCategoriesId == productcategory);
        }

        public ProductSeries GetProductSeries(int id)
        {
            return _productseriesRepository.GetProductSeriesById(id);
        }

        public void UpdateProductSeries(ProductSeries productSeries)
        {
            _productseriesRepository.UpdateProductSeries(productSeries);
        }
    }
}
