using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TEncaissement
{
    public short IdEnc { get; set; }

    public int RefCtrEnc { get; set; }

    public int? RefAdhEnc { get; set; }

    public int? RefAchEnc { get; set; }

    public decimal? MontEnc { get; set; }

    public string? DeviseEnc { get; set; }

    public DateOnly? DatRecepEnc { get; set; }

    public DateOnly? DatValEnc { get; set; }

    public string TypEnc { get; set; } = null!;

    public bool? ValideEnc { get; set; }

    public string? RefEnc { get; set; }

    public string? RibEnc { get; set; }

    public string? BordEnc { get; set; }

    public string? RefSeqEnc { get; set; }

    public bool? Preavis { get; set; }
}
