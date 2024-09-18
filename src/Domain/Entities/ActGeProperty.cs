using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class ActGeProperty
{
    public string Name { get; set; } = null!;

    public string? Value { get; set; }

    public int? Rev { get; set; }
}
