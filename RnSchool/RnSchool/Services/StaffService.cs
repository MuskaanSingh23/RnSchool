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
    public class StaffService:IStaffService
    {
        private readonly IStaffDbProvider _staffdbProvider;
        public StaffService(IStaffDbProvider staffdbProvider)
        {
            _staffdbProvider = staffdbProvider;
        }

        //get staffrole
        public object StaffRole => throw new NotImplementedException();

        public List<StaffRoleResponse> GetStaffRoleList()
        {
            var list = _staffdbProvider.GetStaffRoleList();
            var response=list.Select(e => new StaffRoleResponse()
            {
                RoleId = e.RoleId,
                RoleName=e.RoleName
            }).ToList();
            
            return response;
        }

        //post staff
        public StaffResponse AddStaff(StaffAddRequest staffAddRequest)
        {
            Staff staff = new Staff();
            staff.FirstName = staffAddRequest.FirstName;
            staff.LastName = staffAddRequest.LastName;
            staff.Email = staffAddRequest.Email;
            staff.Mobile = staffAddRequest.Mobile;
            staff.RoleId = staffAddRequest.RoleId;
            staff.DateOfJoining = DateTime.Now;

            var ExistingEmail = _staffdbProvider.GetExistingStaffByEmail(staffAddRequest.Email);

            if (ExistingEmail != null)
            {
                throw new Exception("this email already exist");

            }
            else
            {
                var dbResponse = _staffdbProvider.AddStaff(staff);
            }

            return null;


        }

        //get staff

        public object Staff => throw new NotImplementedException();


        public List<StaffResponse> GetStaffList()
        {
            var list = _staffdbProvider.GetStaffList();
            var response = list.Select(e => new StaffResponse()
            {
                StaffId = e.StaffId,
                FirstName = e.FirstName,
                LastName = e.LastName,
                Email = e.Email,
                Mobile = e.Mobile,
                RoleId = e.RoleId


            }).ToList();
            return response;

        }
    }
}
