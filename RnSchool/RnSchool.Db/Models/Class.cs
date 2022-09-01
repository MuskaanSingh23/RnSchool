using System;
using System.Collections.Generic;

namespace RnSchool.Db.Models
{
    public partial class Class
    {
        public Class()
        {
            Students = new HashSet<Students>();
        }

        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public int? MonitorStudentId { get; set; }
        public int? ClassTeacherId { get; set; }

        public virtual Staff ClassTeacher { get; set; }
        public virtual Students MonitorStudent { get; set; }
        public virtual ICollection<Students> Students { get; set; }
    }
}
