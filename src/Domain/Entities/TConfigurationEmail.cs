using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TConfigurationEmail
{
    public int? IdFactor { get; set; }

    public string? Email { get; set; }

    public string? Mdp { get; set; }

    public string? Smtp { get; set; }

    public int? Port { get; set; }

    public bool? EnableSsl { get; set; }

    public int Id { get; set; }
}
