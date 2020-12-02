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
            // Look for any meetings.
            if (context.Meetings.Any())
            {
                return;   // DB has been seeded
            }

            var meetings = new Meeting[]
            {
            new Meeting{MeetingDate=DateTime.Parse("2005-09-01"),Conductor="Alexander Laureta",OpeningHymn="The Spirit of God",Invocation="Leo Cristiano",SacramentHymn="As Now We Take The Sacrament",ClosingHymn="Because I Have Given Much",Benediction="Meredith Laurence",Notes=""}
            };
            foreach (Meeting s in meetings)
            {
                context.Meetings.Add(s);
            }
            context.SaveChanges();

            var speakers = new Speaker[]
            {
            new Speaker{SpeakerIndex=1,FullName="George Flint",Topic="Faith",Notes="",MeetingID=1},
            new Speaker{SpeakerIndex=2,FullName="Maria Diaz",Topic="Faith",Notes="",MeetingID=1},
            new Speaker{SpeakerIndex =3,FullName="Zola Giuseppe",Topic="Faith",Notes="",MeetingID=1}
            };
            foreach (Speaker c in speakers)
            {
                context.Speakers.Add(c);
            }
            context.SaveChanges();
        }

    }
}
