using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TFondGarantieAv
{
    public string TypFdgAv { get; set; } = null!;

    public int RefCtrFdgAv { get; set; }

    public string? LibFdgAv { get; set; }

    public decimal? TxFdgAv { get; set; }

    public decimal? MontMaxFdgAv { get; set; }

    public decimal? MontMinFdgAv { get; set; }

    public string? TypDocRemisFdgAv { get; set; }
}
