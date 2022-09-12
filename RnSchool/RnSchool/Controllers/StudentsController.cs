using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RnSchool.DataContacts.Request;
using RnSchool.DataContacts.Response;
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
        public IActionResult AddStudents(StudentAddRequest studentAddRequest)
        {
            Payload payload = new Payload();
            
            try
            {
                _studentsService.AddStudents(studentAddRequest);
                payload.Message = "success";
                payload.IsSuccess = true;
                
            }
            catch (Exception ex)
            {

                payload.Message = ex.Message;
                payload.IsSuccess = false;
            }
            return Ok(payload);
            

        }

        [Route("student")]
        [HttpPut]
        public IActionResult UpdateStudents(StudentsUpdateRequest studentsUpdateRequest)
        {
            Payload payload = new Payload();

            try
            {
                _studentsService.UpdateStudents(studentsUpdateRequest);
                payload.Message = "Success";
                payload.IsSuccess = true;

            }
            catch (Exception ex)
            {
                payload.Message = ex.Message;
                payload.IsSuccess = false;

            }

            return Ok(payload);
        }





    }
}
