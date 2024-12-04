namespace API.Models
{
    public class Subject
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }

        public List<Speciality> Specialities { get; set; } = new();

        public List<Lesson> Lessons { get; set; } = new();
    }
}
