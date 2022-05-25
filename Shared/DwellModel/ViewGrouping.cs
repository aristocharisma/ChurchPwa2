using System;
using System.Collections.Generic;

#nullable disable

namespace ChurchPwa2.Shared.DwellModels
{
    public partial class ViewGrouping
    {
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
        public int UserIdmodifiedBy { get; set; }
        public string SiteName { get; set; }
        public int OrganisationId { get; set; }
        public string FullNameOfPersonLeading { get; set; }
        public string TelCell { get; set; }
        public string Email { get; set; }
        public string FullNameOfElderOverseeing { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
    }
}
