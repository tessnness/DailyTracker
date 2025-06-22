using AutoMapper;
using DailyTracker.API.Models.Domain;
using DailyTracker.API.Models.DTO;

namespace DailyTracker.API.Mappings
{
    public class AutoMapperProfiles: Profile
    {

        public AutoMapperProfiles() 
        {
            CreateMap<Tracker, TrackerDto>().ReverseMap();

        }
    }
}
