using System;
using System.Collections.Generic;

#nullable disable

namespace ChurchPwa2.Shared.DwellModels
{
    public partial class GroupingRole
    {
        public GroupingRole()
        {
            PersonGroupings = new HashSet<PersonGrouping>();
        }

        public int Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<PersonGrouping> PersonGroupings { get; set; }
    }
}
