using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TDocPhysique
{
    public string TypDocPhy { get; set; } = null!;

    public int RefCtrDocPhy { get; set; }

    public DateOnly? DatValidDocPhy { get; set; }

    public DateOnly? DatExpirDocPhy { get; set; }

    public bool? DocBloqDocPhy { get; set; }

    public string? RefUserDocPhy { get; set; }

    public bool? DocRecuDocPhy { get; set; }

    public bool? IsSent { get; set; }

    public bool? IsSentMissDoc { get; set; }
}
