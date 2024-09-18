using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TBordFactor
{
    public int IdBordFactor { get; set; }

    public string? NumBordFactor { get; set; }

    public int? IdFactorBordFactor { get; set; }

    public int RefCtrBordFactor { get; set; }

    public decimal? MontTotBordFactor { get; set; }

    public DateOnly? DatCreBordFactor { get; set; }

    public DateOnly? DatEditBordFactor { get; set; }

    public bool ValidBordFactor { get; set; }

    public int? IdEncBordFactor { get; set; }

    public string? RefEncBordFactor { get; set; }
}
