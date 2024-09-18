using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TMotifLit
{
    public int RefCtrMotifLit { get; set; }

    public string TypMotifLit { get; set; } = null!;

    public string? LibMotifLit { get; set; }

    public short? DelaiResolMotifLit { get; set; }

    public bool? RetroAutoMotifLit { get; set; }

    public bool? AlerteLitMotifLit { get; set; }

    public bool? FraisMotifLit { get; set; }

    public string? LoginUserMotifLit { get; set; }
}
