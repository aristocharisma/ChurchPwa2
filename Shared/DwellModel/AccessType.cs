using System;
using System.Collections.Generic;

#nullable disable

namespace ChurchPwa2.Shared.DwellModels
{
    public partial class AccessType
    {
        public AccessType()
        {
            GroupSecurities = new HashSet<GroupSecurity>();
        }

        public string Id { get; set; }
        public string AccessType1 { get; set; }
        public int Level { get; set; }

        public virtual ICollection<GroupSecurity> GroupSecurities { get; set; }
    }
}
