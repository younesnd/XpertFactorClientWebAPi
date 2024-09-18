using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TFraisDiver
{
    public string TypFraisDivers { get; set; } = null!;

    public int RefCtrFraisDivers { get; set; }

    public decimal? MontParUnitFraisDivers { get; set; }

    public string? LibFraisDivers { get; set; }
}
