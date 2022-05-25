using System;
using System.Collections.Generic;

#nullable disable

namespace ChurchPwa2.Shared.DwellModels
{
    public partial class GroupSecurity
    {
        public int Id { get; set; }
        public int UserGroupId { get; set; }
        public int SecurityItemId { get; set; }
        public string AccessTypeId { get; set; }

        public virtual AccessType AccessType { get; set; }
        public virtual SecurityItem SecurityItem { get; set; }
        public virtual Group UserGroup { get; set; }
    }
}
