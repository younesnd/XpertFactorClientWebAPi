using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class ActRuExecution
{
    public string Id { get; set; } = null!;

    public int? Rev { get; set; }

    public string? RootProcInstId { get; set; }

    public string? ProcInstId { get; set; }

    public string? BusinessKey { get; set; }

    public string? ParentId { get; set; }

    public string? ProcDefId { get; set; }

    public string? SuperExec { get; set; }

    public string? SuperCaseExec { get; set; }

    public string? CaseInstId { get; set; }

    public string? ActId { get; set; }

    public string? ActInstId { get; set; }

    public byte? IsActive { get; set; }

    public byte? IsConcurrent { get; set; }

    public byte? IsScope { get; set; }

    public byte? IsEventScope { get; set; }

    public byte? SuspensionState { get; set; }

    public int? CachedEntState { get; set; }

    public decimal? SequenceCounter { get; set; }

    public string? TenantId { get; set; }

    public virtual ICollection<ActRuEventSubscr> ActRuEventSubscrs { get; set; } = new List<ActRuEventSubscr>();

    public virtual ICollection<ActRuExtTask> ActRuExtTasks { get; set; } = new List<ActRuExtTask>();

    public virtual ICollection<ActRuIncident> ActRuIncidentExecutions { get; set; } = new List<ActRuIncident>();

    public virtual ICollection<ActRuIncident> ActRuIncidentProcInsts { get; set; } = new List<ActRuIncident>();

    public virtual ICollection<ActRuTask> ActRuTaskExecutions { get; set; } = new List<ActRuTask>();

    public virtual ICollection<ActRuTask> ActRuTaskProcInsts { get; set; } = new List<ActRuTask>();

    public virtual ICollection<ActRuVariable> ActRuVariableExecutions { get; set; } = new List<ActRuVariable>();

    public virtual ICollection<ActRuVariable> ActRuVariableProcInsts { get; set; } = new List<ActRuVariable>();

    public virtual ICollection<ActRuExecution> InverseParent { get; set; } = new List<ActRuExecution>();

    public virtual ICollection<ActRuExecution> InverseProcInst { get; set; } = new List<ActRuExecution>();

    public virtual ICollection<ActRuExecution> InverseSuperExecNavigation { get; set; } = new List<ActRuExecution>();

    public virtual ActRuExecution? Parent { get; set; }

    public virtual ActReProcdef? ProcDef { get; set; }

    public virtual ActRuExecution? ProcInst { get; set; }

    public virtual ActRuExecution? SuperExecNavigation { get; set; }
}
