using MFEC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MFEC.Domain.Interfaces
{
    public interface IWriteRepository<TEntity> : IDisposable where TEntity : Entity
    {
        TEntity Insert(TEntity entity);
        TEntity Update(TEntity entity);
        void Remove(Guid id);
        int SaveChanges();
    }
}
