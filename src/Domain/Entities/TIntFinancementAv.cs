using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TIntFinancementAv
{
    public string TypInstrIntFinAv { get; set; } = null!;

    public int RefCtrIntFinAv { get; set; }

    public decimal? TxIntMarcheIntFinAv { get; set; }

    public decimal? TxMargeCtrIntFinAv { get; set; }

    public short? DelaiMaxPaiIntFinAv { get; set; }

    public decimal? PrecompteIntFinAv { get; set; }

    public decimal? MajorIntIntFinAv { get; set; }

    public DateOnly? DatDebValidIntFinAv { get; set; }
}
