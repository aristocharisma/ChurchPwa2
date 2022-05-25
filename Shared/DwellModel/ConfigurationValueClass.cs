using System;
using System.Collections.Generic;

#nullable disable

namespace ChurchPwa2.Shared.DwellModels
{
    public partial class ConfigurationValueClass
    {
        public int ID { get; set; }
        public string ConfigurationKey { get; set; }
        public string ConfigurationValue { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime RecordDate { get; set; }
        public int UserIdmodifiedBy { get; set; }
    }
}
