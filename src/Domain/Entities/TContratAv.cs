using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TContratAv
{
    public int RefCtrAv { get; set; }

    public string? StatutCtrAv { get; set; }

    public string? RefCtrPapierCtrAv { get; set; }

    public bool? ServiceCtrAv { get; set; }

    public string? TypCtrAv { get; set; }

    public DateOnly? DatSignCtrAv { get; set; }

    public DateOnly? DatDebCtrAv { get; set; }

    public DateOnly? DatResilCtrAv { get; set; }

    public DateOnly? DatProchVersCtrAv { get; set; }

    public decimal? CaCtrAv { get; set; }

    public decimal? CaExpCtrAv { get; set; }

    public decimal? CaImpCtrAv { get; set; }

    public decimal? LimFinCtrAv { get; set; }

    public string? DeviseCtrAv { get; set; }

    public short? NbAchPrevuCtrAv { get; set; }

    public short? NbFactPrevuCtrAv { get; set; }

    public short? NbAvoirsPrevuCtrAv { get; set; }

    public short? NbRemisesPrevuCtrAv { get; set; }

    public short? DelaiMoyenRegCtrAv { get; set; }

    public short? DelaiMaxRegCtrAv { get; set; }

    public bool? FactRegCtrAv { get; set; }

    public decimal? DernMontDisp2Av { get; set; }

    public decimal? MinCommFactAv { get; set; }

    public bool? IsNotifiedAv { get; set; }

    public string? OldStatutCtrAv { get; set; }

    public DateOnly? DatCreationCtrAv { get; set; }

    public int? RespCtr1Av { get; set; }

    public int? RespCtr2Av { get; set; }

    public bool? StatutPpNotifAv { get; set; }

    public decimal? ConcentrationCtrAv { get; set; }

    public decimal? MntMoyFactCtrAv { get; set; }

    public DateOnly? DateEditCtrAv { get; set; }

    public string? SignatairesDuContratAv { get; set; }

    public string? SignatairesDuContratRegAv { get; set; }

    public string? SignatairesDuContratTypAv { get; set; }

    public string? RefIdcAv { get; set; }

    public string? RefLimiteAv { get; set; }

    public int? AnalystCtr1Av { get; set; }

    public int? AnalystCtr2Av { get; set; }

    public string? CompteDispoAv { get; set; }

    public int? NbFactRemisesCtrAv { get; set; }

    public string? CompteFinAv { get; set; }

    public double? ScoreAv { get; set; }

    public bool? ContratFLoadAv { get; set; }

    public int? RefCtrFk { get; set; }

    public string? AvStatus { get; set; }

    public bool? SendNotifMnqGar { get; set; }

    public bool? SendNotifMnqGer { get; set; }

    public virtual TContrat? RefCtrFkNavigation { get; set; }
}
