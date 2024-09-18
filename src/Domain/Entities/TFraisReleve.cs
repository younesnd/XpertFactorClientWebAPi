using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TFraisReleve
{
    public int IdFraisRel { get; set; }

    public int? RefCtr { get; set; }

    public DateOnly? DatRecepEnc { get; set; }

    public string? TypEnc { get; set; }

    public int? NbPiéce { get; set; }

    public decimal? MontParInstrFraisPaie { get; set; }

    public decimal? Tva { get; set; }

    public decimal? Taxtva { get; set; }

    public decimal? Ttcpp { get; set; }

    public decimal? Mntttct { get; set; }

    public DateOnly? DateReleveFrais { get; set; }
}
