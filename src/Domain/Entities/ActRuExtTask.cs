using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class ActRuExtTask
{
    public string Id { get; set; } = null!;

    public int Rev { get; set; }

    public string? WorkerId { get; set; }

    public string? TopicName { get; set; }

    public int? Retries { get; set; }

    public string? ErrorMsg { get; set; }

    public string? ErrorDetailsId { get; set; }

    public DateTime? LockExpTime { get; set; }

    public DateTime? CreateTime { get; set; }

    public byte? SuspensionState { get; set; }

    public string? ExecutionId { get; set; }

    public string? ProcInstId { get; set; }

    public string? ProcDefId { get; set; }

    public string? ProcDefKey { get; set; }

    public string? ActId { get; set; }

    public string? ActInstId { get; set; }

    public string? TenantId { get; set; }

    public decimal Priority { get; set; }

    public string? LastFailureLogId { get; set; }

    public virtual ActGeBytearray? ErrorDetails { get; set; }

    public virtual ActRuExecution? Execution { get; set; }
}
