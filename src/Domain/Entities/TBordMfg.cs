using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TBordMfg
{
    public int IdBordMfg { get; set; }

    public int? RefCtrBordMfg { get; set; }

    public int? RefAdhBordMfg { get; set; }

    public string? NomAdhBordMfg { get; set; }

    public string? NumBordMfg { get; set; }

    public decimal? MntCommHtBordMfg { get; set; }

    public DateOnly? DateBordMfg { get; set; }

    public DateOnly? DateEnvoieBordMfg { get; set; }
}
