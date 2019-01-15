using MFEC.Domain.Interfaces;
using MFEC.Domain.Models;
using MFEC.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace MFEC.Infra.Data.Repositories
{
    public abstract class Repository<TEntity> : IRepository<TEntity>, IWriteRepository<TEntity> where TEntity : Entity, new()
    {
        protected MfecContext Db;
        protected DbSet<TEntity> DbSet;

        public Repository()
        {
            Db = new MfecContext();
            DbSet = Db.Set<TEntity>();
        }

        public virtual TEntity Insert(TEntity entity)
        {
            var savedEntity = DbSet.Add(entity);
            SaveChanges();
            return savedEntity;
        }

        public virtual TEntity Update(TEntity entity)
        {
            var entry = Db.Entry(entity);
            DbSet.Attach(entity);
            entry.State = EntityState.Modified;
            SaveChanges();
            return entity;
        }

        public virtual void Remove(Guid id)
        {
            var ent = new TEntity { Id = id };
            DbSet.Remove(ent);
        }

        public virtual TEntity GetById(Guid id)
        {
            return DbSet.FirstOrDefault(e => e.Id == id);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return DbSet.ToList();
        }

        public virtual IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.Where(predicate);
        }

        public virtual IEnumerable<TEntity> GetAllPaginated(int skipCount, int takeCount)
        {
            return DbSet.Skip(skipCount).Take(takeCount);
        }

        public int SaveChanges()
        {
            return Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
        }
    }
}
