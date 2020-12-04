namespace SacramentMeetingPlanner.Models
{
    public class SpeakingAssignment
    {
        public int SpeakingAssignmentID { get; set; }
        public int MeetingID { get; set; }
        public int SpeakerID { get; set; }
        public string Topic { get; set; }

        public Speaker Speaker { get; set; }
        public Meeting Meeting { get; set; }
    }
}
