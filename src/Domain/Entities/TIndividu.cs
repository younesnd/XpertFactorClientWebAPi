using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TIndividu
{
    public int RefInd { get; set; }

    public string? GenreInd { get; set; }

    public string? TypDocIdInd { get; set; }

    public string? NumDocIdInd { get; set; }

    public string? LieuDocIdInd { get; set; }

    public DateOnly? DateDocIdInd { get; set; }

    public string? CodTvaInd { get; set; }

    public string? NomInd { get; set; }

    public string? PreInd { get; set; }

    public DateOnly? DatNaissCreat { get; set; }

    public bool? GrpInd { get; set; }

    public decimal? LimCredGloInd { get; set; }

    public decimal? LimFinGloInd { get; set; }

    public string? InfoInd { get; set; }

    public DateOnly? DatInfoInd { get; set; }

    public int? IdNldp { get; set; }

    public string? CodSclas { get; set; }

    public string? AbrvInd { get; set; }

    public byte[]? LogoInd { get; set; }

    public byte[]? PhotoInd { get; set; }

    public string? MfInd { get; set; }

    public string? RcInd { get; set; }

    public bool? ExoTva { get; set; }

    public DateOnly? DatDebExo { get; set; }

    public DateOnly? DatFinExo { get; set; }

    public string? TelInd { get; set; }

    public string? FaxInd { get; set; }

    public string? EmailInd { get; set; }

    public string? RefAdhInd { get; set; }

    public string? FromJurInd { get; set; }

    public bool? ExoInd { get; set; }

    public string? AdrInd { get; set; }

    public string? CpInd { get; set; }

    public string? RefAchInd { get; set; }

    public int? IdGroupe { get; set; }

    public string? ClientIdBt { get; set; }

    public string? SecteurEco { get; set; }

    public bool? Negociant { get; set; }

    public bool? PolitExpose { get; set; }

    public bool? BlackListe { get; set; }

    public DateOnly? DateKyc { get; set; }

    public string? IsClientBt { get; set; }

    public string? CodeDouane { get; set; }

    public string? MatRespSeg1 { get; set; }

    public string? MatRespSeg2 { get; set; }

    public string? DepRespSeg1 { get; set; }

    public string? DepRespSeg2 { get; set; }

    public decimal? CapInd { get; set; }

    public string? Segment1 { get; set; }

    public string? Segment2 { get; set; }

    public virtual ICollection<TAdresse> TAdresses { get; set; } = new List<TAdresse>();

    public virtual ICollection<TjCir> TjCirs { get; set; } = new List<TjCir>();
}
