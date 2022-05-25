using System;
using System.Collections.Generic;

#nullable disable

namespace ChurchPwa2.Shared.DwellModels
{
    public partial class User
    {
        public User()
        {
            GroupUsers = new HashSet<GroupUser>();
            LoginHistories = new HashSet<LoginHistory>();
            Messages = new HashSet<Message>();
            UserOrganisations = new HashSet<UserOrganisation>();
        }

        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string LoginCode { get; set; }
        public string Password { get; set; }
        public int? DefaultUserGroupId { get; set; }
        public string Email { get; set; }
        public DateTime? InactiveDate { get; set; }
        public bool ReadOnly { get; set; }
        public string CellphoneNumber { get; set; }
        public int? PersonId { get; set; }
        public string SecurityQuestion { get; set; }
        public string SecurityAnswer { get; set; }
        public int? DefaultEmployeeId { get; set; }
        public DateTime? DatePasswordChanged { get; set; }

        public virtual ICollection<GroupUser> GroupUsers { get; set; }
        public virtual ICollection<LoginHistory> LoginHistories { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
        public virtual ICollection<UserOrganisation> UserOrganisations { get; set; }
    }
}
