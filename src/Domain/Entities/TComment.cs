using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TComment
{
    public int IdComment { get; set; }

    public string? Action { get; set; }

    public string Comment { get; set; } = null!;

    public DateOnly DateComment { get; set; }

    public DateOnly? DateTraiteComment { get; set; }

    public string ValidationType { get; set; } = null!;

    public bool IsResolved { get; set; }

    public int IdAction { get; set; }

    public int? RefCtrAction { get; set; }
}
