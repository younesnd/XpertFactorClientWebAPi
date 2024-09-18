using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace XpertFactorClientWebAPi.Domain.StoredProcedureModel;
[Keyless]
public class DisponibleAdhWeb
{
    public string? CTR { get; set; }
    public string? ADH { get; set; }
    public decimal? Encours { get; set; }
    public decimal? Disponible { get; set; }
    public decimal? Disponible2 { get; set; }
    public decimal? Fond_Reserve { get; set; }
    public decimal? FDG { get; set; }
    public decimal? Retenu { get; set; }
    public decimal? Depass_Limites { get; set; }
    public decimal? TMM_Marge { get; set; }
    public decimal? Impaye { get; set; }
    public decimal? Retard_p { get; set; }
    public decimal? Litige { get; set; }


}
