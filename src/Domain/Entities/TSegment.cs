using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TSegment
{
    public int IdSeg { get; set; }

    public string? TypeSeg { get; set; }

    public string? DepartSeg { get; set; }

    public string? SegmentSeg { get; set; }

    public string? AbrevSeg { get; set; }

    public string? RolesSeg { get; set; }

    public string? UsersSeg { get; set; }

    public string? MatriculeUserSeg { get; set; }

    public string? ResponsableSeg { get; set; }

    public string? MatricleRespSeg { get; set; }

    public bool? ValideSeg { get; set; }
}
