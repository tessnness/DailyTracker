using DailyTracker.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace DailyTracker.API.Data
{
    public class DailyTrackerDbContext: DbContext
    {
        public DailyTrackerDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions) 
        { 

        }

        public DbSet<Tracker> Tracker { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<Item> Items { get; set; }
    }
}
