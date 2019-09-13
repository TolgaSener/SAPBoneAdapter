using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BaseLibrary.Data.Contracts
{
    public interface IRepository<TEntity, in TKey> where TEntity : class
    {
        Task<TEntity> GetAsync(TKey id);
        TEntity GetEntity(Expression<Func<TEntity, bool>> predicate);
        TEntity GetEntity(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, bool>> predicat);
        TEntity GetEntity(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, bool>> predicat, Expression<Func<TEntity, bool>> predicatt);
        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> GetAll(int skip, int take);
        IQueryable<TEntity> GetAll(int skip, int take, Expression<Func<TEntity, bool>> predicate);
        IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate);
        void Add(TEntity entity);
        void AddRange(List<TEntity> entity);
        void Update(TEntity entity);
        Task Delete(TKey id);
        void Delete(TEntity entity);
        IQueryable<TEntity> FuncGetAll(string str);
        IEnumerable<TEntity> FuncGetEnumerableAll(string str);
        string FuncString(string str);
        int FuncInt(string str);
        string FuncStringResult(string str);
        Task SaveChangeAsync();
        int SaveChanges();


    }
}
