using System;
using System.Collections.Generic;
using System.Linq;
using Earnventory.Domain.Context;
using Earnventory.Domain.Database;
using Earnventory.Domain.Entities;
using Earnventory.Services.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Earnventory.Services.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly ApplicationDbContext Context;
        private readonly DbSet<T> _entities;

        public Repository(ApplicationDbContext ctx)
        {
            Context = ctx;
            _entities = ctx.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return _entities.AsEnumerable();
        }

        public T GetById(Guid id)
        {
            return _entities.SingleOrDefault(s => s.Id == id);
        }

        public T Insert(T entity,Guid? userId = null)
        {
            if (entity == null) throw new ArgumentException("entity cannot be null");
            entity.CreatedBy = userId;
            _entities.Add(entity);
            Context.SaveChanges();
            return entity;
        }

        public void Update(T entity,Guid? userId = null)
        {
            if (entity == null) throw new ArgumentException("entity cannot be null");
            entity.UpdatedAt = DateTime.Now;
            entity.LastUpdatedBy = userId;
            
            _entities.Update(entity);
            Context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var entity = _entities.SingleOrDefault(s => s.Id == id);
            if (entity != null)
                _entities.Remove(entity);
            Context.SaveChanges();
        }
    }
   
}