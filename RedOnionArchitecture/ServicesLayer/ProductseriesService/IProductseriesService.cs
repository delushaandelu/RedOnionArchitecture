using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLayer.ProductseriesService
{
    public interface IProductseriesService
    {
        IEnumerable<ProductSeries> GetAllProductSeries();
        IEnumerable<ProductSeries> GetAllProductSeriesByProductCategory(int productcategory);
        ProductSeries GetProductSeries(int id);
        void CreateNewProductSeries(ProductSeries productSeries);
        void UpdateProductSeries(ProductSeries productSeries);
        void DeleteProductSeries(int id);
    }
}
