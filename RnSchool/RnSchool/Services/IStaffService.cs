using RnSchool.DataContacts.Request;
using RnSchool.DataContacts.Response;
using RnSchool.Db.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RnSchool.Services
{
    public interface IStaffService
    {
        object StaffRole { get; }

        List<StaffRoleResponse> GetStaffRoleList();
        StaffResponse AddStaff(StaffAddRequest staffAddRequest);
        List<StaffResponse> GetStaffList();


    }
}
