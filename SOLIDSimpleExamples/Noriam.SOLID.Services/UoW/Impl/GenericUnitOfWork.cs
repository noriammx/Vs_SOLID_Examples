using Noriam.SOLID.Model;
using Noriam.SOLID.Services.Repository.Contract;
using Noriam.SOLID.Services.Repository.Impl;
using Noriam.SOLID.Services.UoW.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noriam.SOLID.Services.UoW.Impl
{
    public class GenericUnitOfWork : IGenericUnitOfWork
    {

        private readonly ABC_SOLIDEntities entities = null;
        public Dictionary<Type, object> repositories = new Dictionary<Type, object>();

        public GenericUnitOfWork(ABC_SOLIDEntities entities)
        {
            this.entities = entities;
        }

        public IGenericRepository<T> GetRepoInstance<T>() where T : class
        {
            if (repositories.Keys.Contains(typeof(T)) == true)
            {
                return repositories[typeof(T)] as IGenericRepository<T>;
            }

            IGenericRepository<T> repo = new GenericRepository<T>(entities);
            repositories.Add(typeof(T), repo);
            return repo;
        }

        public void SaveChanges()
        {
            entities.SaveChanges();

        }
    }
}
