using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TEcComptable
{
    public int IdEcCpt { get; set; }

    public string? TypTrEcCpt { get; set; }

    public DateOnly? DatSaisEcCpt { get; set; }

    public DateOnly? DatEffEcCpt { get; set; }

    public decimal? MontEcCpt { get; set; }

    public string? RefEcCpt { get; set; }

    public string? DescEcCpt { get; set; }

    public string? IdUserEcEpt { get; set; }

    public string? LotEcCpt { get; set; }

    public string? DeviseEcCpt { get; set; }

    public string? CodeEntEcCpt { get; set; }

    public long? LigneEcCpt { get; set; }

    public int? RefAdhEcCpt { get; set; }

    public string? TypDocEcCpt { get; set; }

    public string? CodJournalEcCpt { get; set; }

    public string? SeqCodJournalEcCpt { get; set; }

    public string? DecsSrcCgEcCpt { get; set; }

    public string? DomaineEcCpt { get; set; }
}
