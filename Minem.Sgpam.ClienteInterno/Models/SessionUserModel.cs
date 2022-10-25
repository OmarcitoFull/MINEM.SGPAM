using System.Collections.Generic;

namespace Minem.Sgpam.ClienteInterno.Models
{
    public class SessionUserModel
    {
        public int SystemID { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string SessionName { get; set; }
        public List<UserRolesUserModel> Roles { get; set; }
    }

    public class UserRolesUserModel
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public List<RoleOptionsModel> Options { get; set; }
    }

    public class RoleOptionsModel
    {
        public int OptionID { get; set; }
        public string OptionName { get; set; }
    }
}
