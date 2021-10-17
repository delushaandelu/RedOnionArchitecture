using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repositroy.ProductCategory
{
    public class ProductcategoryRepository<T> : IProductcategoryRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private DbSet<T> _entities;

        public ProductcategoryRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
            _entities = _applicationDbContext.Set<T>();
        }

        public void CreateNewProductCategory(T entity)
        {
            if(entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            else
            {
                _entities.Add(entity);
                _applicationDbContext.SaveChanges();
            }
        }

        public void DeleteProductCategory(T entity)
        {
            if(entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            else
            {
                _entities.Remove(entity);
                _applicationDbContext.SaveChanges();
            }
        }

        public IEnumerable<T> GetAllProductCategory()
        {
            return _entities.AsEnumerable();
        }

        public T GetProductCategoryById(int id)
        {
            return _entities.SingleOrDefault(x => x.Id == id);
        }

        public void Remove(T entity)
        {
            if(entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            else
            {
                _entities.Remove(entity);
            }
        }

        public void SaveChanges()
        {
            _applicationDbContext.SaveChanges();
        }

        public void UpdateProductCategory(T entity)
        {
            if(entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            else
            {
                _entities.Update(entity);
                _applicationDbContext.SaveChanges();
            }
        }
    }
}
