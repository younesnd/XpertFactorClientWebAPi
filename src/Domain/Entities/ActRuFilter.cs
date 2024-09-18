using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class ActRuFilter
{
    public string Id { get; set; } = null!;

    public int Rev { get; set; }

    public string ResourceType { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Owner { get; set; }

    public string Query { get; set; } = null!;

    public string? Properties { get; set; }
}
