using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCost.Enumes
{
    [Flags]
    public enum RoleTypes
    {
        User = 1,
        Admin = 2,
        StoreStaff = 3
    }
}
