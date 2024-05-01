using System;
using System.Collections.Generic;

namespace _2.ExistingDatabase.Models;

public partial class Student
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Email { get; set; }

    public int ClassId { get; set; }

    public virtual Class Class { get; set; } = null!;

    public virtual ICollection<Score> Scores { get; } = new List<Score>();
}
