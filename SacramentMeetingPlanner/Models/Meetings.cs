using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentMeetingPlanner.Models
{
    public class Meetings
    {
        public int ID { get; set; }
        public DateTime MeetingDate { get; set; }
        public string Conductor { get; set; }
        public string OpeningHymn { get; set; }
        public string Invocation { get; set; }
        public string SacramentHymn { get; set; }
        public ICollection<Speaker> Speakers { get; set; }
        public string ClosingHymn { get; set; }
        public string Benediction { get; set; }
    }
}
