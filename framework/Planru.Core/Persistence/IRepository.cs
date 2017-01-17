using Planru.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Planru.Core.Persistence
{
    public interface IRepository<T> : IDisposable 
        where T: IEntity
    {
        T GetById(Guid id);

        void Add(T entity);

        void Update(T entity);

        void Delete(Guid id);
    }
}
