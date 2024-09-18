using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TInfoCtr
{
    public int IdInfoCtr { get; set; }

    public int? RefInfoCtr { get; set; }

    public string? LibelleInfoCtr { get; set; }

    public DateOnly? DateInfoCtr { get; set; }

    public int? IdUserInfoCtr { get; set; }
}
