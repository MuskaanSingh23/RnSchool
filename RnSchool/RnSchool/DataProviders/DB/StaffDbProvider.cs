using RnSchool.Db.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RnSchool.DataProviders.DB
{
    public class StaffDbProvider:IStaffDbProvider
    {
        private readonly rnschoolDBContext _dbContext;
        public StaffDbProvider(rnschoolDBContext db)
        {
            _dbContext = db;
        }
        public List<StaffRole> GetStaffRoleList()
        {
           var list= _dbContext.StaffRole.ToList();
            return list;
        }

        //get staff
        public List<Staff> GetStaffList()
        {
            var list = _dbContext.Staff.ToList();
            return list;
        }

        public Staff AddStaff(Staff staff)
        {
            _dbContext.Staff.Add(staff);
            _dbContext.SaveChanges();
            return staff;
        }

        public Staff GetExistingStaffByEmail(string email)
        {
            var emaildb = _dbContext.Staff.Where(e => e.Email == email).FirstOrDefault();


            return emaildb;
        }


    }
   
}
