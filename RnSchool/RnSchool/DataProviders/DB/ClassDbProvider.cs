using Microsoft.AspNetCore.Mvc;
using RnSchool.DataContacts.Request;
using RnSchool.DataContacts.Response;
using RnSchool.Db.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RnSchool.DataProviders.DB
{
    public class ClassDbProvider : IClassDbProvider
    {
        private readonly rnschoolDBContext _dBContext;
        public ClassDbProvider(rnschoolDBContext dBContext)
        {
            _dBContext = dBContext;
        }
        public Class AddClass(Class classes)
        {
            _dBContext.Class.Add(classes);
            _dBContext.SaveChanges();
           
            return classes;
        }

        public Class GetExistingClassByName(string className)
        {
            var classdb = _dBContext.Class.Where(e => e.ClassName == className).FirstOrDefault();
           
            return classdb;
        }

        public List<Class> GetClassList()
        {
            
            var list = _dBContext.Class.ToList();
            
            return list;
        }
    }
}




       
        
             
   




