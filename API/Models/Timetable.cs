using System.Security.Cryptography.X509Certificates;

namespace API.Models
{
    public class Timetable
    {
        public Group Group { get; set; }
        public Event Event { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly Time_start { get; set; }
        public TimeOnly Time_end { get; set; }
    }
}
