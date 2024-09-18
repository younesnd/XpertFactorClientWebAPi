using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TDetAss
{
    public int RefAss { get; set; }

    public int? RefCtrAss { get; set; }

    public decimal? PrimeAss { get; set; }

    public decimal? TxCouvertureAss { get; set; }

    public int? DelaisDecalarationSinistreAss { get; set; }

    public bool? ActifAss { get; set; }
}
