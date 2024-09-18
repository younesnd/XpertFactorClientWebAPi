using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TDetAchatReleve
{
    public int IdDetAchatRel { get; set; }

    public string? NomIndDetAchatRel { get; set; }

    public int? RefCtrDetAchatRel { get; set; }

    public string? TypDetBordDetAchatRel { get; set; }

    public string? NumBordDetAchatRel { get; set; }

    public string? RefDocumentDetAchatRel { get; set; }

    public decimal? MontTtcDetAchatRel { get; set; }

    public DateOnly? DatDetBordDetAchatRel { get; set; }

    public DateOnly? DatEcheanceDetAchatRel { get; set; }

    public decimal? MontTtcCommDetAchatRel { get; set; }

    public decimal? TxCommDetAchatRel { get; set; }

    public DateOnly? DatBordDetAchatRel { get; set; }
}
