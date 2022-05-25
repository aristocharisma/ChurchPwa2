using System;
using System.Collections.Generic;

#nullable disable

namespace ChurchPwa2.Shared.DwellModels
{
    public partial class Organisation
    {
        public Organisation()
        {
            Messages = new HashSet<Message>();
            Sites = new HashSet<Site>();
        }

        public int Id { get; set; }
        public string OrganisationName { get; set; }
        public string TelephoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string Address { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string CountryCode { get; set; }
        public string TypeOfOrganisation { get; set; }
        public string CompanyRegNum { get; set; }
        public string MainActivities { get; set; }
        public short? YearFounded { get; set; }
        public string Surname { get; set; }
        public string FirstName { get; set; }
        public string KnownAs { get; set; }
        public string Email { get; set; }
        public string Cellphone { get; set; }
        public string Notes { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime RecordDate { get; set; }
        public int UserIdmodifiedBy { get; set; }
        public DateTime? DateSignedUp { get; set; }

        public virtual ICollection<Message> Messages { get; set; }
        public virtual ICollection<Site> Sites { get; set; }
    }
}
