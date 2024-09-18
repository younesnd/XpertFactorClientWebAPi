using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TCalcDispo
{
    public int IdCalcDispo { get; set; }

    public DateOnly? DateCalcDispo { get; set; }

    public decimal? DispoCalcDispo { get; set; }

    public int? RefAdhCalcDispo { get; set; }

    public int? RefCtrCalcDispo { get; set; }

    public decimal? SomFactCalcDispo { get; set; }

    public decimal? SomAvoirCalcDispo { get; set; }

    public decimal? SomCommFactorCalcDispo { get; set; }

    public decimal? SomTvaCommFatorCalcDispo { get; set; }

    public decimal? SomDebitCalcDispo { get; set; }

    public decimal? SomCreditCalcDispo { get; set; }

    public decimal? SomFdgFactCalcDispo { get; set; }

    public decimal? SomFdgLibereCalcDispo { get; set; }

    public decimal? FinanceCalcDispo { get; set; }

    public decimal? InteretJCalcDispo { get; set; }

    public decimal? MargeJCalcDispo { get; set; }

    public decimal? TmmJCalcDispo { get; set; }

    public decimal? SomLitigeEchusNetCalcDispo { get; set; }

    public decimal? SomLitigeNonEchusNetCalcDispo { get; set; }

    public decimal? DepasLimNetDispo { get; set; }

    public decimal? EngagementNetDispo { get; set; }
}
