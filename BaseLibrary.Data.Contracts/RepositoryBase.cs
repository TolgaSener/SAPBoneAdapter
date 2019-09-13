using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BaseLibrary.Data.Contracts.DataBase;

namespace BaseLibrary.Data.Contracts
{
    public class RepositoryBase<TEntity, TKey> : IRepository<TEntity, TKey> where TEntity : class
    {
        private readonly DbContext _dbContext;
        private readonly DbSet<TEntity> _dbSet;
        private bool _disposed;

        public RepositoryBase()
        {
            _dbContext = new CheckOutEntities();
            _dbSet = _dbContext.Set<TEntity>();
        }

        #region IRepository members
        public Task<TEntity> GetAsync(TKey id)
        {
            return _dbSet.FindAsync(id);
        }

        public TEntity GetEntity(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbSet.Where(predicate).FirstOrDefault();
        }

        public TEntity GetEntity(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, bool>> predicat)
        {
            return _dbSet.Where(predicat).Where(predicate).FirstOrDefault();
        }
        public TEntity GetEntity(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, bool>> predicat, Expression<Func<TEntity, bool>> predicatt)
        {
            return _dbSet.Where(predicat).Where(predicate).Where(predicatt).FirstOrDefault();
        }
        public IQueryable<TEntity> GetAll()
        {

            return _dbSet;
        }

        public IQueryable<TEntity> GetAll(int skip, int take)
        {
            return _dbSet.Skip(skip).Take(take);
        }

        public IQueryable<TEntity> GetAll(int skip, int take, Expression<Func<TEntity, bool>> predicate)
        {
            return GetAll(skip, take).Where(predicate);
        }

        public IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbSet.Where(predicate);
        }

        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public void AddRange(List<TEntity> entity)
        {
            _dbSet.AddRange(entity);
        }

        public void Update(TEntity entity)
        {

            _dbSet.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
        }

        public async Task Delete(TKey id)
        {
            var entity = await GetAsync(id);

            Delete(entity);
        }

        public void Delete(TEntity entity)
        {
            _dbContext.Entry(entity).State = EntityState.Deleted;
        }
        public IQueryable<TEntity> FuncGetAll(string str)
        {
            return _dbContext.Database.SqlQuery<TEntity>(str).AsQueryable();
        }
        public IEnumerable<TEntity> FuncGetEnumerableAll(string str)
        {
            return _dbContext.Database.SqlQuery<TEntity>(str).ToList();
        }
        public string FuncString(string str)
        {
            return _dbContext.Database.SqlQuery<string>(str).FirstOrDefault();
        }

        public int FuncInt(string str)
        {
            return _dbContext.Database.SqlQuery<int>(str).FirstOrDefault();
        }
        public Task SaveChangeAsync()
        {
            return _dbContext.SaveChangesAsync();
        }

        public int SaveChanges()
        {
            return _dbContext.SaveChanges();
        }

        public string FuncStringResult(string str)
        {
            //((IObjectContextAdapter)this._dbContext).ObjectContext.CommandTimeout = 24000;
            var sa = _dbContext.Database.ExecuteSqlCommandAsync(str).Result;
            return "";
        }
        #endregion

        #region IDisposable members
        ~RepositoryBase()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (disposing && !_disposed)
            {
                _dbContext.Dispose();
            }

            _disposed = true;
        }



        #endregion
    }
}
