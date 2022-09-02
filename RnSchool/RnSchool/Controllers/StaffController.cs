using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RnSchool.Db.Models;
using RnSchool.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RnSchool.Controllers
{
    
    [Route("api/staff")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly IStaffService _staffService;
        public StaffController(IStaffService staffService)
        {
            _staffService = staffService;
        }

        [Route("roles")]
        [HttpGet]
        public IActionResult GetStaffRoleList()
        {
           
            var list= _staffService.GetStaffRoleList();

            return Ok(list);
        }
    }
}
