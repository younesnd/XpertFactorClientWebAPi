using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XpertFactorClientWebAPi.Domain.StoredProcedureModel;

namespace XpertFactorClientWebAPi.Application.Interfaces;
public interface IDisponibleAdhWeb
{
    Task<IEnumerable<DisponibleAdhWeb>> GetDisponibleAdhWebAsync(string loginCtr);
}
