using System;
using System.Collections.Generic;

#nullable disable

namespace ChurchPwa2.Shared.DwellModels
{
    public partial class ViewUserGroupSecurityItem
    {
        public int? UserGroupSecurityId { get; set; }
        public int UserGroupId { get; set; }
        public string UserGroup { get; set; }
        public int SecurityItemId { get; set; }
        public string SecurityItem { get; set; }
        public string Code { get; set; }
        public string AccessTypeId { get; set; }
        public string AccessType { get; set; }
        public int Level { get; set; }
    }
}
