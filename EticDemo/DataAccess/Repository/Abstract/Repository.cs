using DataAccess.Context;
using Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.Abstract
{
    public abstract class Repository<Entity> : IRepository<Entity> where Entity : BaseEntity
    {
        private readonly EticDbContext _dbContext;

        protected Repository(EticDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        

        public void Add(Entity entity)
        {
            _dbContext.Set<Entity>().Add(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(Entity entity)
        {
            _dbContext.Set<Entity>().Remove(entity);
            _dbContext.SaveChanges();
        }

        public Entity Get(Expression<Func<Entity, bool>> predicate)
        {
            return _dbContext.Set<Entity>().Where(predicate).FirstOrDefault();
        }

        public List<Entity> GetAll(Expression<Func<Entity, bool>>? predicate = null)
        {
            return predicate == null ? _dbContext.Set<Entity>().ToList() : _dbContext.Set<Entity>().Where(predicate).ToList();
        }
        public IQueryable<Entity> GetAllIQueryalbe(Expression<Func<Entity, bool>>? predicate = null)
        {
            return predicate == null ? _dbContext.Set<Entity>() : _dbContext.Set<Entity>().Where(predicate);
        }

        public void Update(Entity entity)
        {
            _dbContext.Set<Entity>().Update(entity);
            _dbContext.SaveChanges();
        }
    }
}
