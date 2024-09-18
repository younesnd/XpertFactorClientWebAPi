using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TjDocumentDetBord
{
    public int IdDocumentDetBord { get; set; }

    public string IdDetBord { get; set; } = null!;

    public string NumBord { get; set; } = null!;

    public int RefCtrDetBord { get; set; }

    public string RefDocumentDetBord { get; set; } = null!;
}
