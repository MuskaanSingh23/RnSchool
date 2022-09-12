using RnSchool.DataContacts.Request;
using RnSchool.Db.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RnSchool.DataProviders.DB
{
    public interface IStudentsDbProvider
    {
        Students AddStudents(Students students);
        Students GetExistingStudentsByEmail(string email);
        void UpdateStudents(StudentsUpdateRequest studentsUpdateRequest);
        Students GetExistingStudentsById(int studentsId);



    }
}
