using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentMeetingPlanner.Models
{
    public class Speaker
    {
        public int SpeakerID { get; set; }
        public DateTime MeetingDate { get; set; }
        public int SpeakerIndex { get; set; }
        public string FullName { get; set; }
        public string Topic { get; set; }
    }
}
