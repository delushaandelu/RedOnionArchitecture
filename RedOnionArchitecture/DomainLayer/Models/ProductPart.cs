using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class ProductPart : BaseEntity
    {
        public int ProductModelId { get; set; }
        public string PartName { get; set; }
        public string PartDescription { get; set; }
        public string ProductUrl { get; set; }
        public string ImageUrl { get; set; }
        public string Cost { get; set; }

        public ProductModel ProductModel { get; set; }
    }
}
