using RnSchool.DataContacts.Request;
using RnSchool.Db.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RnSchool.DataProviders.DB
{
    public class StudentsDbProvider:IStudentsDbProvider
    {
        private readonly rnschoolDBContext _dbContext;
        public StudentsDbProvider(rnschoolDBContext db)
        {
            _dbContext = db;
        }
       

        public Students AddStudents(Students students)
        {
            _dbContext.Students.Add(students);
            _dbContext.SaveChanges();
            return students;
        }

        public Students GetExistingStudentsByEmail(string email)
        {
            var emaildb = _dbContext.Students.Where(e => e.Email == email).FirstOrDefault();


            return emaildb;
        }
    }
}
