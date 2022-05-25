using System;
using System.Collections.Generic;

#nullable disable

namespace ChurchPwa2.Shared.DwellModels
{
    public partial class Role
    {
        public Role()
        {
            People = new HashSet<Person>();
        }

        public byte Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Person> People { get; set; }
    }
}
