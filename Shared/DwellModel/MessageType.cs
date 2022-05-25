using System;
using System.Collections.Generic;

#nullable disable

namespace ChurchPwa2.Shared.DwellModels
{
    public partial class MessageType
    {
        public MessageType()
        {
            Messages = new HashSet<Message>();
        }

        public short Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Message> Messages { get; set; }
    }
}
