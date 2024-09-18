using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TProrogation
{
    public int RefCtrProg { get; set; }

    public string TypProg { get; set; } = null!;

    public string? MotifProg { get; set; }

    public DateOnly? DatProg { get; set; }

    public DateOnly EchProg { get; set; }

    public bool? EtatProg { get; set; }

    public int IdDetBordProg { get; set; }

    public int IdProrogation { get; set; }

    public bool? IsNotified { get; set; }
}
