using System;
using System.Collections.Generic;

#nullable disable

namespace ChurchPwa2.Shared.DwellModels
{
    public partial class ViewMessageQueueItem
    {
        public int Id { get; set; }
        public int MessageId { get; set; }
        public string To { get; set; }
        public string Bcc { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool IsBodyHtml { get; set; }
        public short SendAttemptMax { get; set; }
        public short CountSendAttempt { get; set; }
        public string ErrorMessage { get; set; }
        public DateTime? DateSent { get; set; }
        public string Context { get; set; }
        public int? PersonId { get; set; }
        public int OrganisationId { get; set; }
        public short MessageTypeId { get; set; }
        public DateTime? DateQueuedToSend { get; set; }
        public string UserNameModifiedBy { get; set; }
        public int AttachmentCount { get; set; }
        public string BodyShort { get; set; }
        public string From { get; set; }
        public string MessageType { get; set; }
        public string FullName { get; set; }
    }
}
