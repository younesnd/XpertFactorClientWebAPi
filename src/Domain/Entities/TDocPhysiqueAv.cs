using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TDocPhysiqueAv
{
    public string TypDocPhyAv { get; set; } = null!;

    public int RefCtrDocPhyAv { get; set; }

    public DateOnly? DatValidDocPhyAv { get; set; }

    public DateOnly? DatExpirDocPhyAv { get; set; }

    public bool? DocBloqDocPhyAv { get; set; }

    public string? RefUserDocPhyAv { get; set; }

    public bool? DocRecuDocPhyAv { get; set; }

    public bool? IsSentAv { get; set; }

    public bool? IsSentMissDocAv { get; set; }
}
