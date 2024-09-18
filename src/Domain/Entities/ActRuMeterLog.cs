using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class ActRuMeterLog
{
    public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Reporter { get; set; }

    public decimal? Value { get; set; }

    public DateTime? Timestamp { get; set; }

    public decimal? Milliseconds { get; set; }
}
