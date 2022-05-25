using System;
using System.Collections.Generic;

#nullable disable

namespace ChurchPwa2.Shared.DwellModels
{
    public partial class ViewPersonNameUnique
    {
        public int Id { get; set; }
        public byte StatusId { get; set; }
        public string FullName { get; set; }
        public string SiteId { get; set; }
        public string OrganisationId { get; set; }
        public byte RoleId { get; set; }
        public DateTime? RecordDate { get; set; }
    }
}
