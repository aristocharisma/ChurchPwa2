using System;
using System.Collections.Generic;

#nullable disable

namespace ChurchPwa2.Shared.DwellModels
{
    public partial class ViewUserGroupUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public DateTime? InactiveDate { get; set; }
        public string LoginCode { get; set; }
        public string Password { get; set; }
        public int? DefaultUserGroupId { get; set; }
        public bool ReadOnly { get; set; }
        public int? SecurityItems { get; set; }
    }
}
