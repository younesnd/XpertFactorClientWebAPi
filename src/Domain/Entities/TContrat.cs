using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TContrat
{
    public int RefCtr { get; set; }

    public string? StatutCtr { get; set; }

    public string? RefCtrPapierCtr { get; set; }

    public bool? ServiceCtr { get; set; }

    public string? TypCtr { get; set; }

    public DateOnly? DatSignCtr { get; set; }

    public DateOnly? DatDebCtr { get; set; }

    public DateOnly? DatResilCtr { get; set; }

    public DateOnly? DatProchVersCtr { get; set; }

    public decimal? CaCtr { get; set; }

    public decimal? CaExpCtr { get; set; }

    public decimal? CaImpCtr { get; set; }

    public decimal? LimFinCtr { get; set; }

    public string? DeviseCtr { get; set; }

    public short? NbAchPrevuCtr { get; set; }

    public short? NbFactPrevuCtr { get; set; }

    public short? NbAvoirsPrevuCtr { get; set; }

    public short? NbRemisesPrevuCtr { get; set; }

    public short? DelaiMoyenRegCtr { get; set; }

    public short? DelaiMaxRegCtr { get; set; }

    public bool? FactRegCtr { get; set; }

    public decimal? DernMontDisp2 { get; set; }

    public decimal? MinCommFact { get; set; }

    public bool? IsNotified { get; set; }

    public string? OldStatutCtr { get; set; }

    public DateOnly? DatCreationCtr { get; set; }

    public int? RespCtr1 { get; set; }

    public int? RespCtr2 { get; set; }

    public bool? StatutPpNotif { get; set; }

    public decimal? ConcentrationCtr { get; set; }

    public decimal? MntMoyFactCtr { get; set; }

    public DateOnly? DateEditCtr { get; set; }

    public string? SignatairesDuContrat { get; set; }

    public string? SignatairesDuContratReg { get; set; }

    public string? SignatairesDuContratTyp { get; set; }

    public string? RefIdc { get; set; }

    public string? RefLimite { get; set; }

    public int? AnalystCtr1 { get; set; }

    public int? AnalystCtr2 { get; set; }

    public string? CompteDispo { get; set; }

    public int? NbFactRemisesCtr { get; set; }

    public string? CompteFin { get; set; }

    public double? Score { get; set; }

    public bool? ContratFLoad { get; set; }

    public virtual ICollection<TCalcInt> TCalcInts { get; set; } = new List<TCalcInt>();

    public virtual ICollection<TDetBord> TDetBords { get; set; } = new List<TDetBord>();

    public virtual ICollection<TjCir> TjCirs { get; set; } = new List<TjCir>();
}
