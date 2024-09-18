using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TAutreFRelele
{
    public int IdAutreFRel { get; set; }

    public int? RefCtrAutreFRel { get; set; }

    public string? AbevAutreFRel { get; set; }

    public decimal? MontAutreFRel { get; set; }

    public string? NomIndAutreFRel { get; set; }

    public DateOnly? DateAutreFRel { get; set; }
}
