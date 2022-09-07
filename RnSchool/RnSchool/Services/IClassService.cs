using RnSchool.DataContacts.Request;
using RnSchool.DataContacts.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RnSchool.Services
{
    public interface IClassService
    {
        ClassResponse AddClass(ClassAddRequest classAddRequest);

        object Class { get; }
        List<ClassResponse> GetClassList();
    }
}
