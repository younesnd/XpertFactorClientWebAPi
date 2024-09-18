using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TLitige
{
    public string TypLit { get; set; } = null!;

    public int RefCtrLit { get; set; }

    public DateOnly? DatLit { get; set; }

    public DateOnly? EchLit { get; set; }

    public decimal? MontLt { get; set; }

    public bool? EtatLit { get; set; }

    public short? IdDetBordLit { get; set; }

    public int IdLitige { get; set; }

    public bool? IsNotifiedLit { get; set; }

    public string? TypLitLibr { get; set; }
}
