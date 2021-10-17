using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class ProductSeries : BaseEntity
    {
        public int ProductCategoriesId { get; set; }
        public string SeriesName { get; set; }
        public string SeriesDescription { get; set; }
        public string ProductUrl { get; set; }
        public string ImageUrl { get; set; }
        public ProductCategory ProductCategory { get; set; }

        public ICollection<ProductModel> ProductModels { get; set; }
    }
}
