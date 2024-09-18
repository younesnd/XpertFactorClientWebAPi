using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class ActGeBytearray
{
    public string Id { get; set; } = null!;

    public int? Rev { get; set; }

    public string? Name { get; set; }

    public string? DeploymentId { get; set; }

    public byte[]? Bytes { get; set; }

    public byte? Generated { get; set; }

    public string? TenantId { get; set; }

    public int? Type { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? RootProcInstId { get; set; }

    public DateTime? RemovalTime { get; set; }

    public virtual ICollection<ActRuExtTask> ActRuExtTasks { get; set; } = new List<ActRuExtTask>();

    public virtual ICollection<ActRuJob> ActRuJobs { get; set; } = new List<ActRuJob>();

    public virtual ICollection<ActRuVariable> ActRuVariables { get; set; } = new List<ActRuVariable>();

    public virtual ActReDeployment? Deployment { get; set; }
}
