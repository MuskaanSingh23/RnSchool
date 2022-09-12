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
    public class StaffController : ControllerBase
    {
        private readonly IStaffService _staffService;
        public StaffController(IStaffService staffService)
        {
            _staffService = staffService;
        }

        [Route("staffroles")]
        [HttpGet]
        public IActionResult GetStaffRoleList()
        {
           
            var list= _staffService.GetStaffRoleList();

            return Ok(list);
        }

        [Route("staff")]
        [HttpPost]
        public IActionResult AddStaff(StaffAddRequest staffAddRequest)
        {
            Payload payload = new Payload();

            try
            {
                _staffService.AddStaff(staffAddRequest);
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

        [Route("staff")]
        [HttpGet]
        public IActionResult GetStaffList()
        {

            var list = _staffService.GetStaffList();

            return Ok(list);
        }
    }
}
