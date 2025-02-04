﻿using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class ActRuJob
{
    public string Id { get; set; } = null!;

    public int? Rev { get; set; }

    public string Type { get; set; } = null!;

    public DateTime? LockExpTime { get; set; }

    public string? LockOwner { get; set; }

    public bool? Exclusive { get; set; }

    public string? ExecutionId { get; set; }

    public string? RootProcInstId { get; set; }

    public string? ProcessInstanceId { get; set; }

    public string? ProcessDefId { get; set; }

    public string? ProcessDefKey { get; set; }

    public int? Retries { get; set; }

    public string? ExceptionStackId { get; set; }

    public string? ExceptionMsg { get; set; }

    public string? FailedActId { get; set; }

    public DateTime? Duedate { get; set; }

    public string? Repeat { get; set; }

    public decimal? RepeatOffset { get; set; }

    public string? HandlerType { get; set; }

    public string? HandlerCfg { get; set; }

    public string? DeploymentId { get; set; }

    public byte SuspensionState { get; set; }

    public decimal Priority { get; set; }

    public string? JobDefId { get; set; }

    public decimal? SequenceCounter { get; set; }

    public string? TenantId { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? LastFailureLogId { get; set; }

    public virtual ActGeBytearray? ExceptionStack { get; set; }
}
