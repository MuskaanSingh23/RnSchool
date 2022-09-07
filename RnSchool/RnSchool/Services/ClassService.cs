using Microsoft.AspNetCore.Mvc;
using RnSchool.DataContacts.Request;
using RnSchool.DataContacts.Response;
using RnSchool.DataProviders.DB;
using RnSchool.Db.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RnSchool.Services
{
    public class ClassService : IClassService
    {
        private readonly IClassDbProvider _classdbProvider;
        public ClassService(IClassDbProvider classdbProvider)
        {
            _classdbProvider = classdbProvider;
        }
        //for post
        public ClassResponse AddClass(ClassAddRequest classAddRequest)
        {
            Class classes = new Class();
            classes.ClassName = classAddRequest.ClassName;
            //check weather the classes name already exist or not
            var ExistingClass = _classdbProvider.GetExistingClassByName(classAddRequest.ClassName);

            //if exist then show error
            if (ExistingClass!=null)
            {
                throw new Exception("this class already exist");
            }
            //if not then add data 
            else
            {
                var dbResponse = _classdbProvider.AddClass(classes);
            }
           
            




            return null;
        }
        
        //for get
        public object Class => throw new NotImplementedException();


        public List<ClassResponse> GetClassList()
        {
            var list = _classdbProvider.GetClassList();
            var response = list.Select(e => new ClassResponse()
            {
                ClassId = e.ClassId,
                ClassName = e.ClassName

            }).ToList();
            return response;

        }

    }
}


