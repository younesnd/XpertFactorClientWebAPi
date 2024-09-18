using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XpertFactorClientWebAPi.Application.TodoLists.Queries.GetTodos;
using XpertFactorClientWebAPi.Domain.Entities;
using XpertFactorClientWebAPi.Domain.StoredProcedureModel;

namespace XpertFactorClientWebAPi.Application.Reporting.DisponibleAdhQuery;
public class DisponibleAdhWebDTO
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
    private class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<DisponibleAdhWeb, DisponibleAdhWebDTO>();
        }
    }
}
