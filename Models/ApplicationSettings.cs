using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class ApplicationSettings
    {
        public int ApplicationSettingId { get; set; }
        public string SettingName { get; set; }
        public string SettingValue { get; set; }
        public string SettingDefault { get; set; }
        public string SettingDesc { get; set; }
        public string ValidationRegex { get; set; }
        public string ValidValues { get; set; }
    }
}
