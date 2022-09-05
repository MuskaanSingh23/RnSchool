using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RnSchool.DataContacts.Request;
using RnSchool.Db.Models;
using RnSchool.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RnSchool.Controllers
{
    [Route("api")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentsService _studentsService;
        public StudentsController(IStudentsService studentsService)
        {
            _studentsService = studentsService;
        }


        [Route("student")]
        [HttpPost]
        public Students PostStudents(StudentAddRequest studentAddRequest)
        {

            return null;
            

        }

       
        


    }
}
