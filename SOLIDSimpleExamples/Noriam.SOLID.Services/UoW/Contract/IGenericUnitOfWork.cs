using Noriam.SOLID.Services.Repository.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noriam.SOLID.Services.UoW.Contract
{
    public interface IGenericUnitOfWork:IDisposable
    {
        IGenericRepository<T> GetRepoInstance<T>() where T : class;

        void SaveChanges();
    }
}
