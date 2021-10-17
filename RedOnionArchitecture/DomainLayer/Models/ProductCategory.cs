using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class ProductCategory : BaseEntity
    {
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public string ProductUrl { get; set; }
        public string ImageUrl { get; set; }

        [JsonIgnore]
        public ICollection<ProductSeries> ProductSeries { get; set; }
    }
}
