using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repositroy.ProductSeries
{
    public interface IProductseriesRepository<T> where T:BaseEntity
    {
        IEnumerable<T> GetAllProductSeries();
        T GetProductSeriesById(int id);
        void CreateNewProductSeries(T entity);
        void UpdateProductSeries(T entity);
        void DeleteProductSeries(T entity);
        void Remove(T entity);
        void SaveChanges();
    }
}
