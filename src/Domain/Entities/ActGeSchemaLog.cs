using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class ActGeSchemaLog
{
    public string Id { get; set; } = null!;

    public DateTime? Timestamp { get; set; }

    public string? Version { get; set; }
}
