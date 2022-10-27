using System.Collections.Generic;

namespace Minem.Sgpam.TransporteDatos.DtoEntidades
{
    public class SessionUserDto
    {
        public int SystemID { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string SessionName { get; set; }
        public List<UserRolesUserDto> Roles { get; set; }
    }

    public class UserRolesUserDto
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public List<RoleOptionsDto> Options { get; set; }
    }

    public class RoleOptionsDto
    {
        public int NumberOrder { get; set; }
        public int OptionID { get; set; }
        public int ParentOption { get; set; }
        public string OptionName { get; set; }

    }
}