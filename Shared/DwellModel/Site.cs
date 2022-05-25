using System;
using System.Collections.Generic;

#nullable disable

namespace ChurchPwa2.Shared.DwellModels
{
    public partial class Site
    {
        public Site()
        {
            Families = new HashSet<Family>();
            Groupings = new HashSet<Grouping>();
        }

        public int Id { get; set; }
        public int OrganisationId { get; set; }
        public string SiteName { get; set; }

        public virtual Organisation Organisation { get; set; }
        public virtual ICollection<Family> Families { get; set; }
        public virtual ICollection<Grouping> Groupings { get; set; }
    }
}
