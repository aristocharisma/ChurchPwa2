using System;
using System.Collections.Generic;

#nullable disable

namespace ChurchPwa2.Shared.DwellModels
{
    public partial class MessageAttachment
    {
        public long Id { get; set; }
        public int MessageId { get; set; }
        public string AttachmentFileName { get; set; }
        public string UniqueFileName { get; set; }
        public string ContentType { get; set; }
        public short? Size { get; set; }
        public string FileNameThumbNail { get; set; }

        public virtual Message Message { get; set; }
    }
}
