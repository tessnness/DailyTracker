using DailyTracker.API.Models.Domain;

namespace DailyTracker.API.Models.DTO
{
    public class TrackerDto
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string Week { get; set; }
        public Boolean IsChecked { get; set; }
        public Participant Participant { get; set; }
        public Item Item { get; set; }
    }
}
