using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RnSchool.DataContacts.Request
{
    public class StudentsUpdateRequest
    {
        public int StudentsId { get; set; }

        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }

        public string Address { get; set; }
        public DateTime Dob { get; set; }
        public int ClassId { get; set; }
    }
}
