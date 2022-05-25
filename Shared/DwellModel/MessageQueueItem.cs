using System;
using System.Collections.Generic;

#nullable disable

namespace ChurchPwa2.Shared.DwellModels
{
    public partial class MessageQueueItem
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

        public virtual Message Message { get; set; }
    }
}
