using System;


namespace SacramentMeetingPlanner.Models
{
    public class Speaker
    {
        public int ID { get; set; }
        public int SpeakerIndex { get; set; }
        public string FullName { get; set; }
        public string Topic { get; set; }
        public string Notes { get; set; }
        public int MeetingID { get; set; }
    }
}
