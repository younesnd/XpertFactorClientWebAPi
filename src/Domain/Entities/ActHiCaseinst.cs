using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class ActHiCaseinst
{
    public string Id { get; set; } = null!;

    public string CaseInstId { get; set; } = null!;

    public string? BusinessKey { get; set; }

    public string CaseDefId { get; set; } = null!;

    public DateTime CreateTime { get; set; }

    public DateTime? CloseTime { get; set; }

    public decimal? Duration { get; set; }

    public byte? State { get; set; }

    public string? CreateUserId { get; set; }

    public string? SuperCaseInstanceId { get; set; }

    public string? SuperProcessInstanceId { get; set; }

    public string? TenantId { get; set; }
}
