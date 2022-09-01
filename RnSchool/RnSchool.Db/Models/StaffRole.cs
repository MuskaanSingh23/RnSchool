using System;
using System.Collections.Generic;

namespace RnSchool.Db.Models
{
    public partial class StaffRole
    {
        public StaffRole()
        {
            Staff = new HashSet<Staff>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Staff> Staff { get; set; }
    }
}
