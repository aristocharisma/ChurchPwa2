using System;
using System.Collections.Generic;

#nullable disable

namespace ChurchPwa2.Shared.DwellModels
{
    public partial class ViewPerson
    {
        public string FamilyName { get; set; }
        public string TelHome { get; set; }
        public string Address { get; set; }
        public string Suburb { get; set; }
        public int? HomeGroupId { get; set; }
        public string FamilyStatus { get; set; }
        public string FullName { get; set; }
        public int Id { get; set; }
        public int FamilyId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TelCell { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Email { get; set; }
        public byte RoleId { get; set; }
        public DateTime? RecordDate { get; set; }
        public int? UserIdmodifiedBy { get; set; }
        public byte StatusId { get; set; }
        public DateTime? DateJoined { get; set; }
        public DateTime? DateLeft { get; set; }
        public string TelWork { get; set; }
        public int? ElderIdOverseeing { get; set; }
        public string Allergies { get; set; }
        public string Comments { get; set; }
        public string UserNameModifiedBy { get; set; }
        public string Status { get; set; }
        public string Role { get; set; }
        public string DateOfBirthMonth { get; set; }
        public string DateOfBirthDay { get; set; }
        public string DateOfBirthMonthName { get; set; }
        public string SpouseFirstName { get; set; }
        public string SpouseFullName { get; set; }
        public int SiteId { get; set; }
        public int OrganisationId { get; set; }
        public string SiteName { get; set; }
        public string PostalCode { get; set; }
        public int? PersonIdSpouse { get; set; }
    }
}
