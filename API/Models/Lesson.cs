using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Lesson
{
    public int GroupId { get; set; }

    public int SubjectId { get; set; }

    public DateOnly Date { get; set; }

    public int Number { get; set; }

    public virtual Group Group { get; set; } = null!;

    public virtual Subject Subject { get; set; } = null!;
}
