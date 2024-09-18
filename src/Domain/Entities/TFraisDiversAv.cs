using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TFraisDiversAv
{
    public string TypFraisDiversAv { get; set; } = null!;

    public int RefCtrFraisDiversAv { get; set; }

    public decimal? MontParUnitFraisDiversAv { get; set; }

    public string? LibFraisDiversAv { get; set; }
}
