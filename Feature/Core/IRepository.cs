using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Feature.Core
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity
    {
        void Add(TEntity obj);
        TEntity GetById(Guid id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate);
        void Update(TEntity obj);
        void Delete(Guid id);        
        int Commit();
    }
}
