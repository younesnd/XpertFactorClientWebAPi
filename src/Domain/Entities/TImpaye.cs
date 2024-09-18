using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TImpaye
{
    public int IdImp { get; set; }

    public int IdEncImp { get; set; }

    public int? IdDetBordImp { get; set; }

    public DateOnly? DateImp { get; set; }

    public DateOnly? DateSaisiImp { get; set; }

    public decimal? MontImp { get; set; }

    public DateOnly? DateResolImp { get; set; }

    public string? IdNvEncs { get; set; }

    public bool? IsResolu { get; set; }
}
