using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repositroy.ProductSeries
{
    public class ProductseriesRepository<T> : IProductseriesRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private DbSet<T> _entities;

        public ProductseriesRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
            _entities = _applicationDbContext.Set<T>();
        }

        public void CreateNewProductSeries(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            else
            {
                _entities.Add(entity);
                _applicationDbContext.SaveChanges();
            }
        }

        public void DeleteProductSeries(T entity)
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

        public IEnumerable<T> GetAllProductSeries()
        {
            return _entities.AsEnumerable();
        }

        public T GetProductSeriesById(int id)
        {
            return _entities.SingleOrDefault(x => x.Id == id);
        }

        public void Remove(T entity)
        {
            if (entity == null)
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

        public void UpdateProductSeries(T entity)
        {
            if (entity == null)
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
