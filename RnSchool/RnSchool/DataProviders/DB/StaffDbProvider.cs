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
    }
   
}
