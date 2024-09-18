using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class ActHiBatch
{
    public string Id { get; set; } = null!;

    public string? Type { get; set; }

    public int? TotalJobs { get; set; }

    public int? JobsPerSeed { get; set; }

    public int? InvocationsPerJob { get; set; }

    public string? SeedJobDefId { get; set; }

    public string? MonitorJobDefId { get; set; }

    public string? BatchJobDefId { get; set; }

    public string? TenantId { get; set; }

    public string? CreateUserId { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public DateTime? RemovalTime { get; set; }

    public DateTime? ExecStartTime { get; set; }
}
