using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class ProductModel : BaseEntity
    {
        public int ProductSeriesId { get; set; }
        public string ModelName { get; set; }
        public string ModelDescription { get; set; }
        public string ProductUrl { get; set; }
        public string ImageUrl { get; set; }
        public string SKU { get; set; }
        public ProductSeries ProductSeries { get; set; }

        public ICollection<ProductPart> ProductParts { get; set; }

    }
}
