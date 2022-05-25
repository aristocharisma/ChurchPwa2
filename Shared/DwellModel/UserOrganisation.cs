using System;
using System.Collections.Generic;

#nullable disable

namespace ChurchPwa2.Shared.DwellModels
{
    public partial class UserOrganisation
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int OrganisationId { get; set; }

        public virtual User User { get; set; }
    }
}
