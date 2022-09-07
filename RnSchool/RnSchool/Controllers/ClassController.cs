using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RnSchool.DataContacts.Request;
using RnSchool.DataContacts.Response;
using RnSchool.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RnSchool.Controllers
{
    [Route("api")]
    [ApiController]
    public class ClassController : ControllerBase
    {
        private readonly IClassService _classService;
        public ClassController(IClassService classService)
        {
            _classService = classService;
        }

        [Route("class")]
        [HttpPost]
        public IActionResult AddClass(ClassAddRequest classAddRequest)
        {
            Payload payload = new Payload();

            try
            {
                _classService.AddClass(classAddRequest);
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
        [Route("classes")]
        [HttpGet]
        public IActionResult GetClassList()
        {

            var list = _classService.GetClassList();

            return Ok(list);
        }
    }
}
