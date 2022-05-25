using System;
using System.Collections.Generic;

#nullable disable

namespace ChurchPwa2.Shared.DwellModels
{
    public partial class ViewSmssendHistory
    {
        public int Id { get; set; }
        public string MessageTo { get; set; }
        public string To { get; set; }
        public string Body { get; set; }
        public DateTime? DateSent { get; set; }
        public int? CreditsUsed { get; set; }
        public string MessageFrom { get; set; }
    }
}
