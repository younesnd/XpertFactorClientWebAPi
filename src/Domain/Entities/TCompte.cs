using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TCompte
{
    public int IdCompt { get; set; }

    public int IdCir { get; set; }

    public string? DeviseAchCpt { get; set; }

    public decimal? LimFinAchAdh { get; set; }

    public short? DelaiPaiCpt { get; set; }

    public string? ModeRegCpt { get; set; }

    public decimal? TotFactCpt { get; set; }

    public decimal? FdgRelFactCpt { get; set; }

    public decimal? DepassLimCpt { get; set; }

    public decimal? TotLitCpt { get; set; }

    public decimal? TotImpCpt { get; set; }

    public DateOnly? DatCpt { get; set; }
}
