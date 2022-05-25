using System;
using System.Collections.Generic;

#nullable disable

namespace ChurchPwa2.Shared.DwellModels
{
    public partial class ViewElder
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int SiteId { get; set; }
        public string FullName { get; set; }
        public string SiteName { get; set; }
        public int OrganisationId { get; set; }
    }
}
