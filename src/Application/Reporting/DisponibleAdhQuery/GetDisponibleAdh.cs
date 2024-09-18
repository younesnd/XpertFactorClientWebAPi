using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using XpertFactorClientWebAPi.Application.Common.Mappings;
using XpertFactorClientWebAPi.Application.Common.Models;
using XpertFactorClientWebAPi.Application.Interfaces;
 

namespace XpertFactorClientWebAPi.Application.Reporting.DisponibleAdhQuery;


public record GetDisponibleAdh : IRequest<PaginatedList<DisponibleAdhWebDTO>>
{
    public int PageNumber { get; init; } = 1;
    public int PageSize { get; init; } = 10;
}

public class GetDisponibleAdhHandler : IRequestHandler<GetDisponibleAdh , IEnumerable<DisponibleAdhWebDTO>> 
{

    private readonly IDisponibleAdhWeb _disponibleAdhWeb;
    private readonly IMapper _mapper;

    public GetDisponibleAdhHandler(IDisponibleAdhWeb disponibleAdhWeb, IMapper mapper)
    {
        _disponibleAdhWeb = disponibleAdhWeb;
        _mapper = mapper;
    }
     
    public async Task<IEnumerable<DisponibleAdhWebDTO>> Handle(GetDisponibleAdh request, CancellationToken cancellationToken)
    {
        var loginCtr = "MCK";

        var disponibleAdhData = await _disponibleAdhWeb.GetDisponibleAdhWebAsync(loginCtr);
        var returnedData = disponibleAdhData.AsQueryable().ProjectTo<DisponibleAdhWebDTO>(_mapper.ConfigurationProvider).ToListAsync()
            


        return returnedData.Result; 
    }


}
