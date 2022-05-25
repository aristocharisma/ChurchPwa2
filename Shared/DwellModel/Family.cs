using System;
using System.Collections.Generic;

#nullable disable

namespace ChurchPwa2.Shared.DwellModels
{
    public partial class Family
    {
        public Family()
        {
            People = new HashSet<Person>();
        }

        public int Id { get; set; }
        public int? SiteId { get; set; }
        public string FamilyName { get; set; }
        public string TelHome { get; set; }
        public string Address { get; set; }
        public string Suburb { get; set; }
        public int? HomeGroupId { get; set; }
        public string Comments { get; set; }
        public string FollowupDetails { get; set; }
        public byte StatusId { get; set; }
        public DateTime? DateJoined { get; set; }
        public DateTime? DateLeft { get; set; }
        public DateTime? RecordDate { get; set; }
        public int? UserIdmodifiedBy { get; set; }
        public string PostalCode { get; set; }
        public virtual Site Site { get; set; }
        public virtual Status Status { get; set; }
        public virtual ICollection<Person> People { get; set; }
    }
}
