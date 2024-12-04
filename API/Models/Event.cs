namespace API.Models
{
    public class Event
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Responsible { get; set; }
        public string? Description { get; set; }
        public string? Place { get; set; }

        public List<Timetable> Timetables { get; set; } = new();

    }
}
