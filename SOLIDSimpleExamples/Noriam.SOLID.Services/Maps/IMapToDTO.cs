using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noriam.SOLID.Services.Maps
{
    /// <summary>
    /// Contrato para implementación de mapeos desde la entidad hacia el DTO
    /// </summary>
    /// <typeparam name="T1">Entidad de la base de datos</typeparam>
    /// <typeparam name="T2">DTO que representa la entidad</typeparam>
    public interface IMapToDTO<T1, T2>
    {
        T2 EntityToDTO(T1 Entity, T2 DTO);
        T2 EntityToDTO(T1 Entity);
    }
}
