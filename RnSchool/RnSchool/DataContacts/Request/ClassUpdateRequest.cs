using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RnSchool.DataContacts.Request
{
    public class ClassUpdateRequest
    {
        public int ClassId { get; set; }
        public int? MonitorStudentId { get; set; }
        public int? ClassTeacherId { get; set; }

    }
}
