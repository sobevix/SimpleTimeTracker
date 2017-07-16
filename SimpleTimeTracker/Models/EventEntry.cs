using System; 

namespace SimpleTimeTracker.Models
{
    public class EventEntry
    {
        public EventEntry()
        {
            Id = new Guid();
            StartTime = DateTime.Now;
        }
        public Guid Id { get; set; }
        public Guid ProjectId { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string ElapsedTime { get; set; } 
    }
}
