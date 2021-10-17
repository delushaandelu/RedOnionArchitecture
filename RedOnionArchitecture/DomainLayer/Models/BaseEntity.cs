using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public string CratedBy { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDateTime { get; set; }
        public bool IsActive { get; set; }
    }
}
