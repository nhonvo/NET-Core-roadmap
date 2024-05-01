using System;
using System.Collections.Generic;

namespace _2.ExistingDatabase.Models;

public partial class Subject
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<Score> Scores { get; } = new List<Score>();
}
