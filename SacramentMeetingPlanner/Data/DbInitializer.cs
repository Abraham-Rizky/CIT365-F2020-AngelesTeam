using SacramentMeetingPlanner.Models;
using System;
using System.Linq;

namespace SacramentMeetingPlanner.Data
{
    public static class DbInitializer
    {
        public static void Initialize(MeetingContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Speakers.Any())
            {
                return;   // DB has been seeded
            }

            var speakers = new Speaker[]
            {
            new Speaker{Name="Alexander Laureta"},
            new Speaker{Name="Norman Mota"},
            new Speaker{Name="Olivetto Rivera"},
            };
            foreach (Speaker s in speakers)
            {
                context.Speakers.Add(s);
            }
            context.SaveChanges();

            var meetings = new Meeting[]
            {
            new Meeting{MeetingDate=DateTime.Parse("2005-09-01"),Conductor="Philip Kim",OpeningHymn="The Spirit of God",Invocation="Leo Cristiano",SacramentHymn="As Now We Take The Sacrament",ClosingHymn="Because I Have Been Given Much",Benediction="Meredith Laurence",Notes=""},
            new Meeting{MeetingDate=DateTime.Parse("2005-09-08"),Conductor="Yong Lopez",OpeningHymn="Come Come Ye Saints",Invocation="Billy Jones",SacramentHymn="God, Our Father, Hear Us Pray",ClosingHymn="I am a Child of God",Benediction="Robert Frias",Notes=""},
            };
            foreach (Meeting c in meetings)
            {
                context.Meetings.Add(c);
            }
            context.SaveChanges();

            var speakingAssignments = new SpeakingAssignment[]
            {
            new SpeakingAssignment{MeetingID=1,SpeakerID=1,Topic="Faith"},
            new SpeakingAssignment{MeetingID=2,SpeakerID=2,Topic="Sacrifice"},
            new SpeakingAssignment{MeetingID=1,SpeakerID=3,Topic="Faith"},
            };
            foreach (SpeakingAssignment e in speakingAssignments)
            {
                context.SpeakingAssignments.Add(e);
            }
            context.SaveChanges();
        }
    }
}