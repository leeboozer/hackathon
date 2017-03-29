using System;
using System.Collections.Generic;

namespace hackathon.Models
{
    public partial class Holidays
    {
        public int HolidayId { get; set; }
        public short HolidayYear { get; set; }
        public byte HolidayMonth { get; set; }
        public DateTime ActualDate { get; set; }
        public DateTime ObservedDate { get; set; }
        public string HolidayName { get; set; }
        public bool FederalHoliday { get; set; }
        public bool SterlingHoliday { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}
