namespace API.Models
{
    public class Stud : User
    {
        public Guid GruppaId { get; set; }
        public Group? Group { get; set; }

    }
}
