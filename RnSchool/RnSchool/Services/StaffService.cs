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
    }
}
