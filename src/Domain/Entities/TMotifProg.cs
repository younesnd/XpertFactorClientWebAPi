using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TMotifProg
{
    public int RefCtrMotifProg { get; set; }

    public string TypMotifProg { get; set; } = null!;

    public string? LibMotifProg { get; set; }

    public bool? AlerteLitMotifProg { get; set; }

    public DateOnly? DatMotifProg { get; set; }

    public DateOnly? EchMotifProg { get; set; }

    public bool? FraisMotifProg { get; set; }

    public string? LoginUserMotifProg { get; set; }
}
