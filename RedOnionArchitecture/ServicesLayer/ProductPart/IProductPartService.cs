using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLayer.ProductPart
{
    public interface IProductPartService
    {
        IEnumerable<DomainLayer.Models.ProductPart> GetAllProductParts();
        IEnumerable<DomainLayer.Models.ProductPart> GetAllProductPartsByProductModel(int productModel);
        DomainLayer.Models.ProductPart GetProductPart(int id);
        void CreateNewProductPart(DomainLayer.Models.ProductPart productPart);
        void UpdateProductPart(DomainLayer.Models.ProductPart productPart);
        void DeleteProductPart(int id);
    }
}
