using System;
using System.Collections.Generic;

namespace RnSchool.Db.Models
{
    public partial class Students
    {
        public Students()
        {
            Class = new HashSet<Class>();
        }

        public int StudentId { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }
        public DateTime AdmissionDate { get; set; }
        public string Address { get; set; }
        public DateTime Dob { get; set; }
        public int ClassId { get; set; }

        public virtual Class ClassNavigation { get; set; }
        public virtual ICollection<Class> Class { get; set; }
    }
}
