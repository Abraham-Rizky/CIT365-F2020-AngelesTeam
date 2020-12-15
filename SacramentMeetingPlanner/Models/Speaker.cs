using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SacramentMeetingPlanner.Models
{
    public class Speaker
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public ICollection<SpeakingAssignment> SpeakingAssignments { get; set; }
    }
}
