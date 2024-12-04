namespace API.Models
{
    public class Prep : User
    {
        public Group? Group { get; set; }
        public List<Lesson> Lessons { get; set; } = new();
    }
}
