using RnSchool.DataContacts.Request;
using RnSchool.DataContacts.Response;
using RnSchool.Db.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RnSchool.DataProviders.DB
{
    public interface IClassDbProvider
    {
        Class AddClass(Class classes);
        
        List<Class> GetClassList();
        Class GetExistingClassByName(string className);
    }
}
