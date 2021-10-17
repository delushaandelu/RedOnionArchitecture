using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class UserRole : BaseEntity
    {
        public string Name { get; set; }
        public string NormalizedName { get; set; }
    }
}
