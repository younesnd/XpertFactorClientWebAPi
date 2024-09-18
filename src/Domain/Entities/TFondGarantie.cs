using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TFondGarantie
{
    public string TypFdg { get; set; } = null!;

    public int RefCtrFdg { get; set; }

    public string? LibFdg { get; set; }

    public decimal? TxFdg { get; set; }

    public decimal? MontMaxFdg { get; set; }

    public decimal? MontMinFdg { get; set; }

    public string? TypDocRemisFdg { get; set; }
}
