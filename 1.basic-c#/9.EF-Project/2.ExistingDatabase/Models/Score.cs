using System;
using System.Collections.Generic;

namespace _2.ExistingDatabase.Models;

public partial class Score
{
    public int Id { get; set; }

    public int StudentId { get; set; }

    public int SubjectId { get; set; }

    public decimal ScoreValue { get; set; }

    public virtual Student Student { get; set; } = null!;

    public virtual Subject Subject { get; set; } = null!;
}
