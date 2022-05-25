using System;
using System.Collections.Generic;

#nullable disable

namespace ChurchPwa2.Shared.DwellModels
{
    public partial class MenuItem
    {
        public int Id { get; set; }
        public string Target { get; set; }
        public string MenuItem1 { get; set; }
        public int? SecurityItemId { get; set; }
        public int? ParentMenuItemId { get; set; }
        public int Order { get; set; }
        public bool AddSeparatorBefore { get; set; }
        public string MenuItemType { get; set; }
        public string ImageFileName { get; set; }
        public short? Level { get; set; }

        public virtual SecurityItem SecurityItem { get; set; }
    }
}
