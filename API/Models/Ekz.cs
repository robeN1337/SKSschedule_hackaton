namespace API.Models
{
    public class Ekz : Event
    {
        public Guid SubjectId { get; set; }
        public Subject? Subject { get; set; }
    }
}
