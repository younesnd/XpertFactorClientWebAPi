using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class ActReDeployment
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public DateTime? DeployTime { get; set; }

    public string? Source { get; set; }

    public string? TenantId { get; set; }

    public virtual ICollection<ActGeBytearray> ActGeBytearrays { get; set; } = new List<ActGeBytearray>();
}
