using System;
using System.Collections.Generic;

#nullable disable

namespace ChurchPwa2.Shared.DwellModels
{
    public partial class Group
    {
        public Group()
        {
            GroupSecurities = new HashSet<GroupSecurity>();
            GroupUsers = new HashSet<GroupUser>();
        }

        public int Id { get; set; }
        public string UserGroup { get; set; }

        public virtual ICollection<GroupSecurity> GroupSecurities { get; set; }
        public virtual ICollection<GroupUser> GroupUsers { get; set; }
    }
}
