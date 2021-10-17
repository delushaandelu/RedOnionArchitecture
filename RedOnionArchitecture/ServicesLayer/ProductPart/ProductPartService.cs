using RepositoryLayer.Repositroy.ProductPart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLayer.ProductPart
{
    public class ProductPartService : IProductPartService
    {
        private IProductpartRepository<DomainLayer.Models.ProductPart> _productpartRepository;

        public ProductPartService(IProductpartRepository<DomainLayer.Models.ProductPart> productpartRepository)
        {
            _productpartRepository = productpartRepository;
        }

        public void CreateNewProductPart(DomainLayer.Models.ProductPart productPart)
        {
            _productpartRepository.Insert(productPart);
        }

        public void DeleteProductPart(int id)
        {
            DomainLayer.Models.ProductPart productPart = GetProductPart(id);
            _productpartRepository.Remove(productPart);
            _productpartRepository.SaveChanges();
        }

        public IEnumerable<DomainLayer.Models.ProductPart> GetAllProductParts()
        {
            return _productpartRepository.GetAll();
        }

        public IEnumerable<DomainLayer.Models.ProductPart> GetAllProductPartsByProductModel(int productModel)
        {
            return _productpartRepository.GetAll().Where(x => x.ProductModelId == productModel);
        }

        public DomainLayer.Models.ProductPart GetProductPart(int id)
        {
            return _productpartRepository.GetById(id);
        }

        public void UpdateProductPart(DomainLayer.Models.ProductPart productPart)
        {
            _productpartRepository.Update(productPart);
        }
    }
}
