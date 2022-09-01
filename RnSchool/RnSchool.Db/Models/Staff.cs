using System;
using System.Collections.Generic;

namespace RnSchool.Db.Models
{
    public partial class Staff
    {
        public Staff()
        {
            Class = new HashSet<Class>();
        }

        public int StaffId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public int RoleId { get; set; }
        public DateTime DateOfJoining { get; set; }

        public virtual StaffRole Role { get; set; }
        public virtual ICollection<Class> Class { get; set; }
    }
}
