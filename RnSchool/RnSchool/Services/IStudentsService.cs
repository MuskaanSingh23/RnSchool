﻿using RnSchool.DataContacts.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RnSchool.Services
{
   public interface IStudentsService
    {
        StudentsResponse PostStudents();
    }
}
