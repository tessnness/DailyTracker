using AutoMapper;
using DailyTracker.API.Data;
using DailyTracker.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace DailyTracker.API.Repositories
{
    public class SQLTrackerRepository: ITrackerRepository
    {
        private readonly DailyTrackerDbContext dbContext;
        private readonly IMapper mapper;

        public SQLTrackerRepository(DailyTrackerDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }
        public async Task<List<Tracker>> GetAllAsync()
        {
            return await dbContext.Tracker.Include("Item").Include("Participant").ToListAsync();
        }

    }
}
