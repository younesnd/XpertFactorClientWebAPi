using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TIntFinancement
{
    public string TypInstrIntFin { get; set; } = null!;

    public int RefCtrIntFin { get; set; }

    public decimal? TxIntMarcheIntFin { get; set; }

    public decimal? TxMargeCtrIntFin { get; set; }

    public short? DelaiMaxPaiIntFin { get; set; }

    public decimal? PrecompteIntFin { get; set; }

    public decimal? MajorIntIntFin { get; set; }

    public DateOnly? DatDebValidIntFin { get; set; }
}
