using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class ActReCamformdef
{
    public string Id { get; set; } = null!;

    public int? Rev { get; set; }

    public string Key { get; set; } = null!;

    public int Version { get; set; }

    public string? DeploymentId { get; set; }

    public string? ResourceName { get; set; }

    public string? TenantId { get; set; }
}
