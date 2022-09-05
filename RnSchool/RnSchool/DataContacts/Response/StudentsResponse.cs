using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RnSchool.DataContacts.Response
{
    public class StudentsResponse
    {
        public int StudentId { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }
        public DateTime AdmissionDate { get; set; }
        public string Address { get; set; }
        public DateTime Dob { get; set; }
        
    }
}
