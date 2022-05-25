using System;
using System.Collections.Generic;

#nullable disable

namespace ChurchPwa2.Shared.DwellModels
{
    public partial class ViewUserGroupSecurity
    {
        public int? Id { get; set; }
        public int UserGroupId { get; set; }
        public int SecurityItemId { get; set; }
        public string AccessTypeId { get; set; }
    }
}
