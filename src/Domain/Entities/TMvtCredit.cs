using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TMvtCredit
{
    public int IdCredit { get; set; }

    public int RefCtrCredit { get; set; }

    public string? AbrvCredit { get; set; }

    public string? TypCredit { get; set; }

    public decimal? MontCredit { get; set; }

    public DateOnly? DateCredit { get; set; }

    public string? LibelleLibreCredit { get; set; }

    public string? RefEncCredit { get; set; }

    public DateOnly? DatValEncCredit { get; set; }
}
