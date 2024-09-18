using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TMvtDebit
{
    public int IdDebit { get; set; }

    public int RefCtrDebit { get; set; }

    public string? AbevDebit { get; set; }

    public string? TypDebit { get; set; }

    public decimal? MontDebit { get; set; }

    public DateOnly? DateDebit { get; set; }
}
