using System;
using System.Collections.Generic;

#nullable disable

namespace ChurchPwa2.Shared.DwellModels
{
    public partial class Message
    {
        public Message()
        {
            MessageAttachments = new HashSet<MessageAttachment>();
            MessageQueueItems = new HashSet<MessageQueueItem>();
        }

        public int Id { get; set; }
        public int OrganisationId { get; set; }
        public short MessageTypeId { get; set; }
        public string To { get; set; }
        public string Cc { get; set; }
        public string Bcc { get; set; }
        public string From { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool? IsBodyHtml { get; set; }
        public DateTime DateModified { get; set; }
        public int UserIdModifiedBy { get; set; }
        public string RecipientIds { get; set; }
        public string Context { get; set; }
        public DateTime? DateQueuedToSend { get; set; }

        public virtual MessageType MessageType { get; set; }
        public virtual Organisation Organisation { get; set; }
        public virtual User UserIdModifiedByNavigation { get; set; }
        public virtual ICollection<MessageAttachment> MessageAttachments { get; set; }
        public virtual ICollection<MessageQueueItem> MessageQueueItems { get; set; }
    }
}
