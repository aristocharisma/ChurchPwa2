using System;
using System.Collections.Generic;

#nullable disable

namespace ChurchPwa2.Shared.DwellModels
{
    public partial class Status
    {
        public Status()
        {
            Families = new HashSet<Family>();
        }

        public byte Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Family> Families { get; set; }
    }
}
