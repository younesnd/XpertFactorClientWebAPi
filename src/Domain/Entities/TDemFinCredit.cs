using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TDemFinCredit
{
    public int IdDemFinCredit { get; set; }

    public int IdCirDem { get; set; }

    public decimal? MontFinDem { get; set; }

    public decimal? MontFinAcc { get; set; }

    public DateOnly? DatFinAcc { get; set; }

    public decimal? MontCreditDem { get; set; }

    public decimal? MontCreditAcc { get; set; }

    public DateOnly? DatCreditAcc { get; set; }
}
