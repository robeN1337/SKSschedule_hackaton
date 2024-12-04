namespace API.Models
{
    public class Speciality
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public List<Group> Groups { get; set; } = new();
        public List<Subject> Subjects { get; set; } = new();
    }
}
