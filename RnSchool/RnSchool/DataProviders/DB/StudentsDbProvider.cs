using RnSchool.Db.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RnSchool.DataProviders.DB
{
    public class StudentsDbProvider:IStudentsDbProvider
    {
        private readonly rnschoolDBContext _dbContext;
        public StudentsDbProvider(rnschoolDBContext db)
        {
            _dbContext = db;
        }
        public Students PostStudents()
        {

            throw new NotImplementedException();
        }

        
    }
}
