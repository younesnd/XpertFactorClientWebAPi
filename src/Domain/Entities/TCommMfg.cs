using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TCommMfg
{
    public int IdMfg { get; set; }

    public string? TypeMfg { get; set; }

    public string? RefAdhMfg { get; set; }

    public string? CodeMfg { get; set; }

    public decimal? MntCommMfg { get; set; }

    public int? NumBordMfg { get; set; }

    public DateOnly? DateSaisieMfg { get; set; }

    public DateOnly? DateEnvoieMfg { get; set; }

    public bool? FlagMfg { get; set; }

    public string? TypeActionMfg { get; set; }
}
