using System.Security.Cryptography.X509Certificates;

namespace API.Models
{
    public class Timetable
    {
        public Guid GroupId { get; set; }
        public Group? Group { get; set; }

        public Guid EventId { get; set; }
        public Event? Event { get; set; }

        public DateOnly Date { get; set; }
        public TimeOnly Time_start { get; set; }
        public TimeOnly Time_end { get; set; }
    }
}
