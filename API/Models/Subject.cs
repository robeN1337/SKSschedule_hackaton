using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Subject
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string Cabinet { get; set; } = null!;

    public string UserLogin { get; set; } = null!;

    public virtual ICollection<Lesson> Lessons { get; set; } = new List<Lesson>();

    public virtual User UserLoginNavigation { get; set; } = null!;
}
