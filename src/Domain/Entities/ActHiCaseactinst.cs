using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class ActHiCaseactinst
{
    public string Id { get; set; } = null!;

    public string? ParentActInstId { get; set; }

    public string CaseDefId { get; set; } = null!;

    public string CaseInstId { get; set; } = null!;

    public string CaseActId { get; set; } = null!;

    public string? TaskId { get; set; }

    public string? CallProcInstId { get; set; }

    public string? CallCaseInstId { get; set; }

    public string? CaseActName { get; set; }

    public string? CaseActType { get; set; }

    public DateTime CreateTime { get; set; }

    public DateTime? EndTime { get; set; }

    public decimal? Duration { get; set; }

    public byte? State { get; set; }

    public byte? Required { get; set; }

    public string? TenantId { get; set; }
}
