using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class ActRuTaskMeterLog
{
    public string Id { get; set; } = null!;

    public decimal? AssigneeHash { get; set; }

    public DateTime? Timestamp { get; set; }
}
