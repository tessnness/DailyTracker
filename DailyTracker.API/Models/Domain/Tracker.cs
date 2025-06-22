namespace DailyTracker.API.Models.Domain
{
    public class Tracker
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string Week {  get; set; }
        public Boolean IsChecked { get; set; }
        public Participant Participant { get; set; }
        public Item Item { get; set; }
    }
}
