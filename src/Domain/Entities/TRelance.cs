using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TRelance
{
    public int IdRelance { get; set; }

    public string? RefCtrRelance { get; set; }

    public string? LibelleRelance { get; set; }

    public DateOnly? DateRelance { get; set; }

    public string? RefDocRelance { get; set; }

    public bool? ValideRelance { get; set; }

    public string? UserRelance { get; set; }
}
