using System;
using System.Collections.Generic;

#nullable disable

namespace ChurchPwa2.Shared.DwellModels
{
    public partial class ViewFamilyNamesUnique
    {
        public int Id { get; set; }
        public byte StatusId { get; set; }
        public string FamilyName { get; set; }
        public int? SiteId { get; set; }
        public int? OrganisationId { get; set; }
        public DateTime? RecordDate { get; set; }
    }
}
