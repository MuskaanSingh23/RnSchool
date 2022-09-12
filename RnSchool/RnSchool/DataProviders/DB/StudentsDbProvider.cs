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

        public Students GetExistingStudentsById(int studentsId)
        {
            var studentsdb = _dbContext.Students.Where(e => e.StudentId == studentsId).FirstOrDefault();

            return studentsdb;
        }

        public void UpdateStudents(StudentsUpdateRequest studentsUpdateRequest)
        {
            var studentsdb = _dbContext.Students.Where(e => e.StudentId == studentsUpdateRequest.StudentsId).First();
            studentsdb.Email = studentsUpdateRequest.Email;
            studentsdb.FirstName = studentsUpdateRequest.FirstName;
            studentsdb.LastName = studentsUpdateRequest.LastName;
            studentsdb.Mobile = studentsUpdateRequest.Mobile;
            studentsdb.Address = studentsUpdateRequest.Address;
            studentsdb.Dob = studentsUpdateRequest.Dob;
            studentsdb.ClassId = studentsUpdateRequest.ClassId;
            _dbContext.SaveChanges();


        }
    }
}
