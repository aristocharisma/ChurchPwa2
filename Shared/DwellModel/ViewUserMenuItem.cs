using System;
using System.Collections.Generic;

#nullable disable

namespace ChurchPwa2.Shared.DwellModels
{
    public partial class ViewUserMenuItem
    {
        public string Target { get; set; }
        public string MenuItem { get; set; }
        public int Id { get; set; }
        public int? ParentMenuItemId { get; set; }
        public int Order { get; set; }
        public int UserId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string ImageFileName { get; set; }
        public short? Level { get; set; }
    }
}
