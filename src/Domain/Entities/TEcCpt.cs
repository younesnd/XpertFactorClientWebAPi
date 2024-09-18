using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TEcCpt
{
    public int IdEcCpt { get; set; }

    public int? AnneeEcCpt { get; set; }

    public string? CodeDepEcCpt { get; set; }

    public string? NumEcEcCpt { get; set; }

    public int? NumLigneEcCpt { get; set; }

    public string? CodeJournalEcCpt { get; set; }

    public DateOnly? DateSaisieEcCpt { get; set; }

    public DateOnly? DateEffetEcCpt { get; set; }

    public string? LibelleeEcCpt { get; set; }

    public string? CompteGenEcCpt { get; set; }

    public decimal? MontantEcCpt { get; set; }

    public string? CodeCentreAnalyseEcCpt { get; set; }

    public string? RefPieceEcCpt { get; set; }

    public string? TypeTransactionEcCpt { get; set; }

    public string? TypeDocEcCpt { get; set; }

    public string? NomUserEcCpt { get; set; }

    public string? LotEcCpt { get; set; }

    public string? CodeTiersEcCpt { get; set; }

    public string? DomaineEcCpt { get; set; }

    public decimal? CreditEcCpt { get; set; }

    public DateOnly? DateEcCpt { get; set; }

    public int? RefAdhEcCpt { get; set; }

    public string? CompteEcCpt { get; set; }

    public string? CodeEcCpt { get; set; }

    public string? IntituleEcCpt { get; set; }

    public string? RefMfgAdhEcCpt { get; set; }

    public int IdEccpt1 { get; set; }

    public int? RefCtrCpt { get; set; }

    public string? LibelleComCpt { get; set; }

    public int? DeviseCpt { get; set; }

    public string? CompteAdhCpt { get; set; }

    public string? CpnvcorgCpt { get; set; }

    public string? CpnvtorgCpt { get; set; }
}
