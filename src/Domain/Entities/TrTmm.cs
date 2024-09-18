using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TrTmm
{
    public DateOnly? DateDebutTmm { get; set; }

    public DateOnly? DateFinTmm { get; set; }

    public decimal? TauxTmm { get; set; }

    public int IdTmm { get; set; }
}
