using System;
using System.Collections.Generic;

#nullable disable

namespace ChurchPwa2.Shared.DwellModels
{
    public partial class Grouping
    {
        public Grouping()
        {
            PersonGroupings = new HashSet<PersonGrouping>();
        }

        public int Id { get; set; }
        public int SiteId { get; set; }
        public string GroupingName { get; set; }
        public string Address { get; set; }
        public string Locality { get; set; }
        public int? PersonIdleading { get; set; }
        public bool LeadingWithSpouse { get; set; }
        public int? ElderIdoverseeing { get; set; }
        public DateTime? DateStarted { get; set; }
        public DateTime? DateEnded { get; set; }
        public DateTime DateModified { get; set; }
        public int UserIdModifiedBy { get; set; }

        public virtual Site Site { get; set; }
        public virtual ICollection<PersonGrouping> PersonGroupings { get; set; }
    }
}
