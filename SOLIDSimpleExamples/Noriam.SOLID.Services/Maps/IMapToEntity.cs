using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noriam.SOLID.Services.Maps
{
    /// <summary>
    /// Contrato para implementación de mapeos desde el DTO a la entidad
    /// </summary>
    /// <typeparam name="T1">Entidad de la base de datos</typeparam>
    /// <typeparam name="T2">DTO que representa la entidad</typeparam>
    public interface IMapToEntity<T1, T2>
    {        
        T1 DTOToEntity(T1 Entity, T2 DTO);        
        T1 DTOToEntity(T2 DTO);
    }
}
