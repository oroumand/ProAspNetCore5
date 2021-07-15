using AshpazbashiBackoffice.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AshpazbashiBackoffice.Infra.Data.Sql.Common
{
    public class EfRepository<TEntity> : IRepository<TEntity> where TEntity : Entity, new()
    {
        protected readonly AshpazbashiDbContext dbContext;

        public EfRepository(AshpazbashiDbContext ashpazbashiDbContext)
        {
            this.dbContext = ashpazbashiDbContext;
        }


        public bool Exists(Expression<Func<TEntity, bool>> expression)
        {
            return dbContext.Set<TEntity>().Any(expression);
        }

        public TEntity Get(Guid id)
        {
            return dbContext.Set<TEntity>().FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return dbContext.Set<TEntity>().ToList();
        }

        public void Insert(TEntity entity)
        {
            dbContext.Add(entity);
            dbContext.SaveChanges();
        }

        public void Remove(TEntity entity)
        {
            dbContext.Remove(entity);
            dbContext.SaveChanges();
        }

        public void SaveChanges()
        {
            dbContext.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            dbContext.Update(entity);
            dbContext.SaveChanges();
        }
    }
}
