using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string FIO { get; set; } = string.Empty;
        public string Login { get; set; } = string.Empty ;
        public DateOnly BirthDate { get; set; }
        public string Password { get; set; } = string.Empty;
    }
}
  