namespace API.Models
{
    public class Group
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public Speciality Speciality {  get; set; }

        public string Curator {  get; set; } = string.Empty ;
    }
}
