using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TAdresse
{
    public short IdAdr { get; set; }

    public int RefIndAdr { get; set; }

    public string? LibAdr { get; set; }

    public string? CpAdr { get; set; }

    public short? IdLocAdr { get; set; }

    public short? IdDelegAdr { get; set; }

    public short? IdGouvAdr { get; set; }

    public short? IdNldp { get; set; }

    public bool? ActifAdr { get; set; }

    public virtual TIndividu RefIndAdrNavigation { get; set; } = null!;
}
