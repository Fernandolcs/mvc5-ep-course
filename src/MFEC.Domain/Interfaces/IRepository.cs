using MFEC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MFEC.Domain.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity
    {
        TEntity GetById(Guid id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetAllPaginated(int skipCount, int takeCount);
        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate);
    }
}
