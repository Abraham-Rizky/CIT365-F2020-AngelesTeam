using Microsoft.EntityFrameworkCore;
using SacramentMeetingPlanner.Models;


namespace SacramentMeetingPlanner.Data
{
    public class MeetingContext : DbContext
    {
        public MeetingContext(DbContextOptions<MeetingContext> options) : base(options)
        {
        }

        public DbSet<Speaker> Speakers { get; set; }
        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<SpeakingAssignment> SpeakingAssignments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Speaker>().ToTable("Speaker");
            modelBuilder.Entity<Meeting>().ToTable("Meeting");
            modelBuilder.Entity<SpeakingAssignment>().ToTable("SpeakingAssignment");
        }
    }
}
