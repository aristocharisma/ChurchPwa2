using System;
using System.Collections.Generic;

#nullable disable

namespace ChurchPwa2.Shared.DwellModels
{
    public partial class MessageCreditsUsed
    {
        public int Id { get; set; }
        public int MessageQueueItemId { get; set; }
        public string MessageSendResult { get; set; }
        public int? CreditsUsed { get; set; }
        public int? CreditsRemaining { get; set; }
    }
}
