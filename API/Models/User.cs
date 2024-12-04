using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FIO { get; set; } = string.Empty;
        public string Login { get; set; } = string.Empty ;
        public string BirthDate { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
  