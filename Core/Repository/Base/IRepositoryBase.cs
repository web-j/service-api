using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.Repository.Base
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();

        TEntity GetById(Guid id);

        TEntity Get(Expression<Func<TEntity, bool>> where);

        IEnumerable<TEntity> GetMany(Expression<Func<TEntity, bool>> where);

        void Add(TEntity obj);

        void Update(TEntity obj);

        void Remove(TEntity obj);

        void Remove(Expression<Func<TEntity, bool>> where);

        void Dispose();
    }
}
