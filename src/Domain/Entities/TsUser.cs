using System;
using System.Collections.Generic;

namespace XpertFactorClientWebAPi.Domain.Entities;

public partial class TsUser
{
    public int IdUser { get; set; }

    public int IdGrpUser { get; set; }

    public string? NomUser { get; set; }

    public string? PreUser { get; set; }

    public string LoginUser { get; set; } = null!;

    public string? MdpUser { get; set; }

    public bool ActifUser { get; set; }

    public string? FonctionUser { get; set; }

    public string? ServiceUser { get; set; }

    public string? DirectionUser { get; set; }

    public string? AgenceUser { get; set; }

    public string? MailUser { get; set; }

    public string? TelFixeUser { get; set; }

    public string? MobileUser { get; set; }

    public string? PhotoUser { get; set; }

    public string? OneSignalPlayerId { get; set; }

    public string? MailGrp { get; set; }

    public string? MatUser { get; set; }

    public bool? Locked { get; set; }

    public string? GenreUser { get; set; }

    public virtual TsGrpUser IdGrpUserNavigation { get; set; } = null!;
}
