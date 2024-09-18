using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using XpertFactorClientWebAPi.Application.Common.Models;
using XpertFactorClientWebAPi.Application.Interfaces;
using XpertFactorClientWebAPi.Domain.StoredProcedureModel;
using XpertFactorClientWebAPi.Infrastructure.Data;
namespace XpertFactorClientWebAPi.Infrastructure.Repositories;


public class DisponibleAdhWebRepository : IDisponibleAdhWeb
{

    private readonly ApplicationDbContext _context;

    public DisponibleAdhWebRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<IEnumerable<DisponibleAdhWeb>> GetDisponibleAdhWebAsync(string loginCtr)
    {
   
        var result = await _context.DisponibleAdhWebResult
           .FromSqlRaw("EXEC Disponible_ADH_WEB_16112019 @LoginCtr = {0}", loginCtr)
           .ToListAsync();


        return result;
    }
}
