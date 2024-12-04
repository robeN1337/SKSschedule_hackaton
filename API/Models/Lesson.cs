namespace API.Models
{
    public class Lesson : Event
    {
        public Guid SubjectId { get; set; }
        public Subject? Subject { get; set; }

        public Guid PrepId { get; set; }
        public Prep? Prep { get; set; } 
    }
}
