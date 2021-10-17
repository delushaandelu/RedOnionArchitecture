using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class User : BaseEntity
    {
        public int UserRoleId { get; set; }
        public string NormalizedUserName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool LockOutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public bool Status { get; set; }

        #region Related
        public virtual UserRole UserRole { get; set; }

        [JsonIgnore]
        public ICollection<UserRole> UserRoles { get; set; }
        #endregion Related
    }
}
