using DailyTracker.API.Models.Domain;

namespace DailyTracker.API.Repositories
{
    public interface ITrackerRepository
    {
        Task<List<Tracker>> GetAllAsync();
    }
}
