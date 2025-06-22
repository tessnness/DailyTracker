using AutoMapper;
using DailyTracker.API.Data;
using DailyTracker.API.Models.DTO;
using DailyTracker.API.Repositories;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace DailyTracker.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrackerController: ControllerBase
    {
        private readonly DailyTrackerDbContext dbContext;
        private readonly IMapper mapper;
        private readonly ITrackerRepository trackerRepository;
        public ITrackerRepository TrackerRepository { get; }

        public TrackerController(DailyTrackerDbContext dbContext, IMapper mapper, ITrackerRepository trackerRepository) 
        {
            this.dbContext = dbContext;
            this.mapper = mapper; 
            this.trackerRepository = trackerRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var trackerModel = await trackerRepository.GetAllAsync();

            return Ok(mapper.Map<List<TrackerDto>>(trackerModel));
        }







    }
}
