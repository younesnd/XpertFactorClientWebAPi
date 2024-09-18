using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TFinancement
{
    public int IdFin { get; set; }

    public int? RefCtrFin { get; set; }

    public int? RefAdhFin { get; set; }

    public decimal? MontFin { get; set; }

    public DateOnly? DatFin { get; set; }

    public string? InstrFin { get; set; }

    public string? RefInstrFin { get; set; }

    public DateOnly? DatInstrFin { get; set; }

    public string? EtatFin { get; set; }

    public int? IdDispoFin { get; set; }

    public string? TypeEnc { get; set; }

    public int? StatusFin { get; set; }

    public DateTime? DatVal { get; set; }
}
