using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TEtatDispo
{
    public int IdEtatDispo { get; set; }

    public int? RefCtrEtatDispo { get; set; }

    public decimal? TotalFactureEtatDispo { get; set; }

    public decimal? TotalFinEtatDispo { get; set; }

    public decimal? TotalAvEtatDispo { get; set; }

    public decimal? TotalCommEtatDispo { get; set; }

    public decimal? TotalFraisEtatDispo { get; set; }

    public decimal? TotalDebitEtatDispo { get; set; }

    public decimal? TotalCreditEtatDispo { get; set; }

    public decimal? TotalInteretEtatDispo { get; set; }

    public decimal? DepassLimiteEtatDispo { get; set; }

    public decimal? TotalRetenueEtatDispo { get; set; }

    public decimal? TotalFdgEtatDispo { get; set; }

    public decimal? DisponibleEtatDispo { get; set; }

    public DateOnly? DateEtatDispo { get; set; }

    public decimal? TotalEncoursFactureEtatDispo { get; set; }

    public decimal? TotalIrEtatDipos { get; set; }

    public decimal? TotalInstruPaimentsImpEtatDipos { get; set; }

    public decimal? TotalRetardPaiementAlgoEtatDispo { get; set; }

    public decimal? TotalLitigesOuvertEtatDispo { get; set; }

    public decimal? TotalDisponible2EtatDispo { get; set; }

    public decimal? TotalFondsReserveEtatDispo { get; set; }

    public decimal? TotalFinancementDuMoisEtatDispo { get; set; }

    public decimal? TotalLitigesEchusEtatDispo { get; set; }
}
