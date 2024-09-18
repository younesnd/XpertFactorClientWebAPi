using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TjAdhWeb
{
    public int IdWeb { get; set; }

    public int RefIndWeb { get; set; }

    public string PreIndWeb { get; set; } = null!;

    public string LoginWeb { get; set; } = null!;

    public string PwdWeb { get; set; } = null!;

    public DateOnly DateDebutWeb { get; set; }

    public DateOnly? DateFinWeb { get; set; }
}
