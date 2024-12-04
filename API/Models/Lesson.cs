namespace API.Models
{
    public class Lesson : Event
    {
        public Subject Name { get; set; }
        public Prep PrepId { get; set; }
    }
}
