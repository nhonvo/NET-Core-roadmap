using System;
using System.Collections.Generic;

namespace _2.ExistingDatabase.Models;

public class Class
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<Student> Students { get; } = new List<Student>();
}
