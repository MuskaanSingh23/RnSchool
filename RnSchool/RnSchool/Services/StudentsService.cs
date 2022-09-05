using RnSchool.DataContacts.Response;
using RnSchool.DataProviders.DB;
using RnSchool.Db.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RnSchool.Services
{
    public class StudentsService:IStudentsService
    {
        private readonly IStudentsDbProvider _studentsdbProvider;
        public StudentsService(IStudentsDbProvider studentsdbProvider)
        {
            _studentsdbProvider = studentsdbProvider;
        }



        public StudentsResponse PostStudents()
        {
           // _studentsdbProvider.PostStudents();
           /* var response = Students.(e => new StudentsResponse()
            {
                StudentId = e.StudentId,
                FirstName = e.FirstName,
                LastName = e.LastName,
                Email = e.Email,
                Address = e.Address,
                AdmissionDate = e.AdmissionDate,

            });
*/
            return null;
        }
    }
}
