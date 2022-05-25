using System;
using System.Collections.Generic;

#nullable disable

namespace ChurchPwa2.Shared.DwellModels
{
    public partial class GroupUser
    {
        public int UserId { get; set; }
        public int UserGroupId { get; set; }

        public virtual User User { get; set; }
        public virtual Group UserGroup { get; set; }
    }
}
