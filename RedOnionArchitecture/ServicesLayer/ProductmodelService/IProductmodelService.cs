using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLayer.ProductmodelService
{
    public interface IProductmodelService
    {
        IEnumerable<ProductModel> GetAllProductModels();
        IEnumerable<ProductModel> GetAllProductModelsByProductSeries(int productSeries);
        ProductModel GetProductModel(int id);
        void CreateNewProductModel(ProductModel productModel);
        void UpdateProductModel(ProductModel productModel);
        void DeleteProductModel(int id);
    }
}
