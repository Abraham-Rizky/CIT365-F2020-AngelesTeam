using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;


namespace SacramentMeetingPlanner.Models
{
    public class Meeting
    {
        public int ID { get; set; }

        [Display(Name = "Meeting Date")]
        [Required(ErrorMessage = "Please Enter a Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime MeetingDate { get; set; }

        [Required(ErrorMessage = "Please enter the first and last name of the conductor.")]
        [RegularExpression(@"^([A-Z][a-z]+\s[A-Z][a-z]+)$", ErrorMessage = "First and last name must be capilatized and only contain letters.")]
        public string Conductor { get; set; }
        
        [Display(Name = "Opening Hymn")]
        [Range(1, 341, ErrorMessage = "Please select a Hymn.")]
        public string OpeningHymn { get; set; }

        [Required(ErrorMessage = "Please enter the first and last name of the invocation.")]
        [RegularExpression(@"^([A-Z][a-z]+\s[A-Z][a-z]+)$", ErrorMessage = "First and last name must be capilatized and only contain letters.")]
        public string Invocation { get; set; }
        
        [Display(Name = "Sacrament Hymn")]
        [Range(1, 341, ErrorMessage = "Please select a Hymn.")]
        public string SacramentHymn { get; set; }
        
        [Display(Name = "Closing Hymn")]
        [Range(1, 341, ErrorMessage = "Please select a Hymn.")]
        public string ClosingHymn { get; set; }

        [Required(ErrorMessage = "Please enter the first and last name of the benediction.")]
        [RegularExpression(@"^([A-Z][a-z]+\s[A-Z][a-z]+)$", ErrorMessage = "First and last name must be capilatized and only contain letters.")]
        public string Benediction { get; set; }
        
        public string Notes { get; set; }

        [Display(Name = "Speaking Assignment")]
        public ICollection<SpeakingAssignment> SpeakingAssignments { get; set; }
        
        public ICollection<Speaker> Speakers { get; set; }

        public ICollection<MyModel> MyModels { get; set; }

    }
}
