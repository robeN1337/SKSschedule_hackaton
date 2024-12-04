namespace API.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public string Speciality {  get; set; } = string.Empty ;

        public string Curator {  get; set; } = string.Empty ;
    }
}
