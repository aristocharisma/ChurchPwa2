using System;
using System.Collections.Generic;

#nullable disable

namespace ChurchPwa2.Shared.DwellModels
{
    public partial class ViewFamily
    {
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
        public string UserNameModifiedBy { get; set; }
        public string Status { get; set; }
        public string SiteName { get; set; }
        public int? OrganisationId { get; set; }
    }
}
