using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class ActRuJobdef
{
    public string Id { get; set; } = null!;

    public int? Rev { get; set; }

    public string? ProcDefId { get; set; }

    public string? ProcDefKey { get; set; }

    public string? ActId { get; set; }

    public string JobType { get; set; } = null!;

    public string? JobConfiguration { get; set; }

    public byte? SuspensionState { get; set; }

    public decimal? JobPriority { get; set; }

    public string? TenantId { get; set; }

    public string? DeploymentId { get; set; }

    public virtual ICollection<ActRuBatch> ActRuBatchBatchJobDefs { get; set; } = new List<ActRuBatch>();

    public virtual ICollection<ActRuBatch> ActRuBatchMonitorJobDefs { get; set; } = new List<ActRuBatch>();

    public virtual ICollection<ActRuBatch> ActRuBatchSeedJobDefs { get; set; } = new List<ActRuBatch>();

    public virtual ICollection<ActRuIncident> ActRuIncidents { get; set; } = new List<ActRuIncident>();
}
