using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TFraisPaiementAv
{
    public string TypFraisPaieAv { get; set; } = null!;

    public int RefCtrFraisPaieAv { get; set; }

    public decimal? MontParInstrFraisPaieAv { get; set; }

    public string? LibFraisPaieAv { get; set; }
}
