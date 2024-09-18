using XpertFactorClientWebAPi.Application.Reporting.DisponibleAdhQuery;
using MediatR;
using XpertFactorClientWebAPi.Application.TodoItems.Queries.GetTodoItemsWithPagination;
using XpertFactorClientWebAPi.Application.Common.Models;

namespace XpertFactorClientWebAPi.Web.Endpoints;

public class DisponibleAdhWeb : EndpointGroupBase
{
    public override void Map(WebApplication app)
    {
        app.MapGroup(this)
           // .RequireAuthorization() 
            .MapGet("/disponible-adh", GetDisponibleAdhApi);
    }

    
    public async Task<PaginatedList<DisponibleAdhWebDTO>> GetDisponibleAdhApi(ISender sender, [AsParameters] GetDisponibleAdh query)
    {
        return await sender.Send(query);
    }
}
