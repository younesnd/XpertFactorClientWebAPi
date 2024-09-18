using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TrIntFinancement
{
    public string TypInstrIntFin { get; set; } = null!;

    public decimal? TxIntMarcheIntFin { get; set; }

    public decimal? TxMargeCtrIntFin { get; set; }

    public short? DelaiMaxPaiIntFin { get; set; }

    public decimal? PrecompteIntFin { get; set; }

    public decimal? MajorIntIntFin { get; set; }

    public DateOnly? DatDebValidIntFin { get; set; }

    public int IdTrIntFin { get; set; }
}
