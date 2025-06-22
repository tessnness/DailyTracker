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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var items = new List<Item>()
            {
                new Item()
                {
                    Id = Guid.Parse("87420699-f622-4a17-858f-c6363de440c1"),
                    Name = "Sport"
                },

                new Item()
                {
                    Id = Guid.Parse("260f704d-8bd5-45ed-bf6a-9fa9f6607d92"),
                    Name = "No alcohol"
                },
                new Item()
                {
                    Id = Guid.Parse("1693788f-ca13-4ed0-8b5b-074389d2a4cd"),
                    Name = "No sugar"
                }
            };

            modelBuilder.Entity<Item>().HasData(items);

            var participants = new List<Participant>()
            {
                new Participant()
                {
                    Id = Guid.Parse("a48e6f70-a9e0-44ca-9c8e-9ef8a70ef8d8"),
                    Name = "Tess"
                },
                new Participant()
                {
                    Id = Guid.Parse("2562d8f5-e514-4af4-b803-0a29fbbb9400"),
                    Name = "Cris"
                }
            };
            modelBuilder.Entity<Participant>().HasData(participants);
        }
    }
}
