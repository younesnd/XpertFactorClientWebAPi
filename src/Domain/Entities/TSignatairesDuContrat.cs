using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TSignatairesDuContrat
{
    public int IdSignatairesDuContrat { get; set; }

    public int? SignatairesDuContratRefCtr { get; set; }

    public string? SignatairesDuContratName { get; set; }

    public string? SignatairesDuContratReg { get; set; }

    public string? SignatairesDuContratTyp { get; set; }
}
