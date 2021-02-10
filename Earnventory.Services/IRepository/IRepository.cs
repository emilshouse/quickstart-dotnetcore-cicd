using System;
using System.Collections.Generic;
using Earnventory.Domain.Entities;

namespace Earnventory.Services.IRepository
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        T GetById(Guid id);
        T Insert(T entity,Guid? userId = null);
        void Update(T entity,Guid? userId = null);
        void Delete(Guid id);
    }
}