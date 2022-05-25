using System;
using System.Collections.Generic;

#nullable disable

namespace ChurchPwa2.Shared.DwellModels
{
    public partial class PersonGrouping
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int GroupingId { get; set; }
        public int? GroupingRoleId { get; set; }

        public virtual Grouping Grouping { get; set; }
        public virtual GroupingRole GroupingRole { get; set; }
        public virtual Person Person { get; set; }
    }
}
