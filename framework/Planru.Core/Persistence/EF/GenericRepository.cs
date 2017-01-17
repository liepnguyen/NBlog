using System;
using Microsoft.EntityFrameworkCore;
using Planru.Core.Domain;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Planru.Core.Persistence.EF
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <typeparam name="TConcreteClass"></typeparam>
    public abstract class GenericRepository<TEntity, TConcreteClass> : IRepository<TEntity>
        where TConcreteClass: EntityBase, TEntity
        where TEntity: IEntity
    {
        public GenericRepository(DbContext context)
        {
            if (context == null)
            {
                throw new ArgumentException("An instance of DbContext is required to use this repository.", "context");
            }

            Context = context;
            DbSet = Context.Set<TConcreteClass>();
        }

        protected DbSet<TConcreteClass> DbSet { get; set; }

        protected DbContext Context { get; set; }

        public virtual TEntity GetById(Guid id)
        {
            return DbSet.Find(id);
        }

        public virtual void Add(TEntity entity)
        {
            EntityEntry entry = Context.Entry((TConcreteClass)entity);
            if (entry.State != EntityState.Detached)
            {
                entry.State = EntityState.Added;
            }
            else
            {
                DbSet.Add((TConcreteClass)entity);
            }
        }

        public virtual void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public virtual void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}
