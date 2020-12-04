using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace SacramentMeetingPlanner.Models
{
    public class Meeting
    {
        public int ID { get; set; }
        
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime MeetingDate { get; set; }
        public string Conductor { get; set; }
        public string OpeningHymn { get; set; }
        public string Invocation { get; set; }
        public string SacramentHymn { get; set; }
        public string ClosingHymn { get; set; }
        public string Benediction { get; set; }
        public string Notes { get; set; }

        public ICollection<SpeakingAssignment> SpeakingAssignments { get; set; }
        public ICollection<Speaker> Speakers { get; set; }

    }
}
