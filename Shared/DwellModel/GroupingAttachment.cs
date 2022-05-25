using System;
using System.Collections.Generic;

#nullable disable

namespace ChurchPwa2.Shared.DwellModels
{
    public partial class GroupingAttachment
    {
        public long Id { get; set; }
        public int GroupingId { get; set; }
        public string AttachmentFileName { get; set; }
        public string UniqueFileName { get; set; }
        public string ContentType { get; set; }
        public string Size { get; set; }
        public string FileNameThumbNail { get; set; }
        public string AttachmentType { get; set; }
        public DateTime DateCreated { get; set; }
        public string UserNameCreatedBy { get; set; }
        public DateTime DateModified { get; set; }
        public string UserNameModifiedBy { get; set; }
    }
}
