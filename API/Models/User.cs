using System;
using System.Collections.Generic;

namespace API.Models;

public partial class User
{
    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Fio { get; set; } = null!;

    public DateOnly Birthday { get; set; }

    public int? GroupId { get; set; }

    public int RoleId { get; set; }

    public virtual Group? Group { get; set; }

    public virtual Role Role { get; set; } = null!;

    public virtual ICollection<Subject> Subjects { get; set; } = new List<Subject>();
}
