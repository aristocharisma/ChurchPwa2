using System;
using System.Collections.Generic;

#nullable disable

namespace ChurchPwa2.Shared.DwellModels
{
    public partial class SecurityItem
    {
        public SecurityItem()
        {
            GroupSecurities = new HashSet<GroupSecurity>();
            MenuItems = new HashSet<MenuItem>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string SecurityItem1 { get; set; }

        public virtual ICollection<GroupSecurity> GroupSecurities { get; set; }
        public virtual ICollection<MenuItem> MenuItems { get; set; }
    }
}
