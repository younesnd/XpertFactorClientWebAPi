using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TBordereauMfg
{
    public int IdBordMfg { get; set; }

    public string? TypeMfg { get; set; }

    public string? RefAdhMfg { get; set; }

    public string? RefAchMfg { get; set; }

    public int? NumBordMfg { get; set; }

    public string? RefDocMfg { get; set; }

    public DateOnly? DateBordMfg { get; set; }

    public decimal? MontTtcDetMfg { get; set; }

    public int? CompteMfg { get; set; }

    public decimal? MontFdgDetMfg { get; set; }

    public decimal? AccFournAdhMfg { get; set; }

    public decimal? MntFinanancementMfg { get; set; }

    public DateOnly? DateCreationMfg { get; set; }

    public DateOnly? DateEnvoieMfg { get; set; }

    public bool? FlagMfg { get; set; }
}
