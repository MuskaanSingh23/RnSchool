using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using RnSchool.Db.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RnSchool.Controllers
{
    [Route("api/admin/[controller]")]
    [ApiController]
    public class StaffRoleController : ControllerBase
    {
        private readonly rnschoolDBContext _db;
        public StaffRoleController(rnschoolDBContext db)
        {
            _db = db;
        }
        

        [HttpGet("{Id}")]
        public StaffRole GetbyId(int RoleId)
        {
            return _db.StaffRole.FirstOrDefault(x => x.RoleId == RoleId);
        }

        [HttpPost]

        public StaffRole Post(StaffRole a)
        {
            _db.StaffRole.Add(a);
            _db.SaveChanges();
            return _db.StaffRole.FirstOrDefault(x => x.RoleId == a.RoleId);
        }
        [HttpDelete("{Id}")]

        public StaffRole Delete(int StaffRoleId)
        {
            var a = _db.StaffRole.Find(StaffRoleId);
            _db.StaffRole.Remove(a);
            _db.SaveChanges();
            return a;
        }

        [HttpPut("{Id}")]

        public StaffRole Put(int RoleId, StaffRole a)
        {
            _db.Entry(a).State = EntityState.Modified;
            _db.SaveChanges();
            return a;
        }
    }
}
