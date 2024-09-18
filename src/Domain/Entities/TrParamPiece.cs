using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TrParamPiece
{
    public string TypParamPiece { get; set; } = null!;

    public string? LibParamPiece { get; set; }

    public string? SignParamPiece { get; set; }
}
