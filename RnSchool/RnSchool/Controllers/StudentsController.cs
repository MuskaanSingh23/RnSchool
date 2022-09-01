using Microsoft.AspNetCore.Mvc;
/*using RnSchool.Models;*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RnSchool.Controllers
{
    [Route("api/user/[controller]")]
    [ApiController]
    public class StudentsController : Controller
    {
        /*private readonly AppDbContext _db;*/

        /*public StudentsController(AppDbContext db)*/
       /* {
            _db = db;
        }*/
       [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
