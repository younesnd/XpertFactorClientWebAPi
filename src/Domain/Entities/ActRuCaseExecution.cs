using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class ActRuCaseExecution
{
    public string Id { get; set; } = null!;

    public int? Rev { get; set; }

    public string? CaseInstId { get; set; }

    public string? SuperCaseExec { get; set; }

    public string? SuperExec { get; set; }

    public string? BusinessKey { get; set; }

    public string? ParentId { get; set; }

    public string? CaseDefId { get; set; }

    public string? ActId { get; set; }

    public int? PrevState { get; set; }

    public int? CurrentState { get; set; }

    public byte? Required { get; set; }

    public string? TenantId { get; set; }

    public virtual ICollection<ActRuCaseSentryPart> ActRuCaseSentryPartCaseExecs { get; set; } = new List<ActRuCaseSentryPart>();

    public virtual ICollection<ActRuCaseSentryPart> ActRuCaseSentryPartCaseInsts { get; set; } = new List<ActRuCaseSentryPart>();

    public virtual ICollection<ActRuTask> ActRuTasks { get; set; } = new List<ActRuTask>();

    public virtual ICollection<ActRuVariable> ActRuVariableCaseExecutions { get; set; } = new List<ActRuVariable>();

    public virtual ICollection<ActRuVariable> ActRuVariableCaseInsts { get; set; } = new List<ActRuVariable>();

    public virtual ActReCaseDef? CaseDef { get; set; }

    public virtual ActRuCaseExecution? CaseInst { get; set; }

    public virtual ICollection<ActRuCaseExecution> InverseCaseInst { get; set; } = new List<ActRuCaseExecution>();

    public virtual ICollection<ActRuCaseExecution> InverseParent { get; set; } = new List<ActRuCaseExecution>();

    public virtual ActRuCaseExecution? Parent { get; set; }
}
