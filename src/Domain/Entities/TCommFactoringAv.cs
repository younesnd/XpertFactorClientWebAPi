using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TCommFactoringAv
{
    public string TypCommFactoringAv { get; set; } = null!;

    public int RefCtrCommFactoringAv { get; set; }

    public decimal? TxCommFactoringAv { get; set; }

    public decimal? MontMinDocCommFactoringAv { get; set; }

    public decimal? MontMinCtrCommFactoringAv { get; set; }
}
