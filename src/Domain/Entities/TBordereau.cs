using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TBordereau
{
    public string NumBord { get; set; } = null!;

    public int RefCtrBord { get; set; }

    public string AnneeBord { get; set; } = null!;

    public int? RefAdhBord { get; set; }

    public int? RefAchBord { get; set; }

    public DateOnly? DatBord { get; set; }

    public short? NbDocBord { get; set; }

    public decimal? MontTotBord { get; set; }

    public string? DeviseAch { get; set; }

    public bool? SoldeBord { get; set; }

    public bool? ValideBord { get; set; }

    public DateOnly? DatSaisieBord { get; set; }

    public string? Emetteur { get; set; }

    public string? StatusBord { get; set; }
}
