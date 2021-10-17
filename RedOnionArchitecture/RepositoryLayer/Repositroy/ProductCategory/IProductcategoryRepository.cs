using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repositroy.ProductCategory
{
    public interface IProductcategoryRepository<T> where T:BaseEntity
    {
        IEnumerable<T> GetAllProductCategory();
        T GetProductCategoryById(int id);
        void CreateNewProductCategory(T entity);
        void UpdateProductCategory(T entity);
        void DeleteProductCategory(T entity);
        void Remove(T entity);
        void SaveChanges();

    }
}
