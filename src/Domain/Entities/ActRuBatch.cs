using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class ActRuBatch
{
    public string Id { get; set; } = null!;

    public int Rev { get; set; }

    public string? Type { get; set; }

    public int? TotalJobs { get; set; }

    public int? JobsCreated { get; set; }

    public int? JobsPerSeed { get; set; }

    public int? InvocationsPerJob { get; set; }

    public string? SeedJobDefId { get; set; }

    public string? BatchJobDefId { get; set; }

    public string? MonitorJobDefId { get; set; }

    public byte? SuspensionState { get; set; }

    public string? Configuration { get; set; }

    public string? TenantId { get; set; }

    public string? CreateUserId { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? ExecStartTime { get; set; }

    public virtual ICollection<ActRuVariable> ActRuVariables { get; set; } = new List<ActRuVariable>();

    public virtual ActRuJobdef? BatchJobDef { get; set; }

    public virtual ActRuJobdef? MonitorJobDef { get; set; }

    public virtual ActRuJobdef? SeedJobDef { get; set; }
}
