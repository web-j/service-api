using Core.Repository.Base;
using Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Repository.Base
{
    public abstract class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly ApplicationContext _context;

        public RepositoryBase(ApplicationContext applicationContext)
        {
            _context = applicationContext;
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public virtual TEntity GetById(Guid id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public virtual void Add(TEntity obj)
        {
            try
            {
                _context.Set<TEntity>().Add(obj);
                _context.SaveChanges();
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual void Update(TEntity obj)
        {
            try
            {
                _context.Entry(obj).State = EntityState.Modified;
                _context.SaveChanges();
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual void Remove(TEntity obj)
        {
            try
            {
                _context.Set<TEntity>().Remove(obj);
                _context.SaveChanges();
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual void Dispose()
        {
            _context.Dispose();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> where)
        {
            return _context.Set<TEntity>().Where(where).FirstOrDefault<TEntity>();
        }

        public IEnumerable<TEntity> GetMany(Expression<Func<TEntity, bool>> where)
        {
            return _context.Set<TEntity>().Where(where).ToList();
        }

        public void Remove(Expression<Func<TEntity, bool>> where)
        {
            IEnumerable<TEntity> objects = _context.Set<TEntity>().Where<TEntity>(where).AsEnumerable();
            foreach (TEntity obj in objects)
                _context.Set<TEntity>().Remove(obj);
        }
    }
}
