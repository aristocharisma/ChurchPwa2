using System;
using System.Collections.Generic;

#nullable disable

namespace ChurchPwa2.Shared.DwellModels
{
    public partial class Person
    {
        public Person()
        {
            PersonGroupings = new HashSet<PersonGrouping>();
        }

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

        public virtual Family Family { get; set; }
        public virtual Role Role { get; set; }
        public virtual ICollection<PersonGrouping> PersonGroupings { get; set; }
    }
}
