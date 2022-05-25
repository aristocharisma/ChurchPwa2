using System;
using System.Collections.Generic;

#nullable disable

namespace ChurchPwa2.Shared.DwellModels
{
    public partial class ViewKidsReport
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string FirstName { get; set; }
        public string MainSurname { get; set; }
        public string MainFirstName { get; set; }
        public string MainTelCell { get; set; }
        public string MainEmail { get; set; }
        public string SpouseSurname { get; set; }
        public string SpouseFirstName { get; set; }
        public string SpouseTelCell { get; set; }
        public string SpouseEmail { get; set; }
        public string Allergies { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int? Age { get; set; }
        public string GroupingName { get; set; }
        public int? GroupingId { get; set; }
        public int? SiteId { get; set; }
        public byte StatusId { get; set; }
        public byte RoleId { get; set; }
        public string Email { get; set; }
        public int OrganisationId { get; set; }
    }
}
