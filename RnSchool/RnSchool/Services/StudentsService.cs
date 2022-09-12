using RnSchool.Controllers;
using RnSchool.DataContacts.Request;
using RnSchool.DataContacts.Response;
using RnSchool.DataProviders.DB;
using RnSchool.Db.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace RnSchool.Services
{
    public class StudentsService: IStudentsService

    {
        
        private readonly IStudentsDbProvider _studentsdbProvider;
        public StudentsService(IStudentsDbProvider studentsdbProvider)
        {
            _studentsdbProvider = studentsdbProvider;
            
        }
        



        public StudentsResponse AddStudents(StudentAddRequest studentAddRequest)
        {
            Students students = new Students();
            students.Address = studentAddRequest.Address;
            
            students.FirstName = studentAddRequest.FirstName;
            students.LastName = studentAddRequest.LastName;
            students.Mobile = studentAddRequest.Mobile;
            students.Email = studentAddRequest.Email;
            students.Dob = studentAddRequest.Dob;
            students.ClassId = studentAddRequest.ClassId;

            students.AdmissionDate = DateTime.Now;
            
            var ExistingEmail = _studentsdbProvider.GetExistingStudentsByEmail(studentAddRequest.Email);

            if (ExistingEmail != null)
            {
                throw new Exception("this email already exist");

            }
            else
            {
                var dbResponse = _studentsdbProvider.AddStudents(students);
            }

            return null;

            
        }

        public void UpdateStudents(StudentsUpdateRequest studentsUpdateRequest)
        {
            Students students = new Students();
            students.StudentId = studentsUpdateRequest.StudentsId;
           
            var ExistingStudents = _studentsdbProvider.GetExistingStudentsById(studentsUpdateRequest.StudentsId);

            //if exist then show error
            if (ExistingStudents != null)
            {
                _studentsdbProvider.UpdateStudents(studentsUpdateRequest);

            }
            //if not then add data 
            else
            {
                throw new Exception("this student does not exist");
            }

        }
       



    }
}
