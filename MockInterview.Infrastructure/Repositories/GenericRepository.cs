using Microsoft.EntityFrameworkCore;
using MockInterview.Infrastructure.Context;
using MockInterview.Infrastructure.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MockInterview.Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {

        /// <summary>
        /// Connect network base
        /// </summary>
        internal MockInterviewDBContext _dbContext;
        protected DbSet<T> _dbSet;

        /// <summary>
        /// Call Constructor
        /// </summary>
        /// <param name="dbContext"></param>
        /// <param name="dbSet"></param>
        public GenericRepository(MockInterviewDBContext dbContext, DbSet<T> dbSet)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }



        /// <summary>
        /// Create
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<T> CreateAsync(T entity)
        {
            var entry = await _dbSet.AddAsync(entity);

            await _dbContext.SaveChangesAsync();

            return entry.Entity;
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<bool> DeleteAsync(Expression<Func<T, bool>> expression)
        {
            var entity = await _dbSet.FirstOrDefaultAsync(expression);
            if (entity == null)
                return false;

            _dbSet.Remove(entity);

            await _dbContext.SaveChangesAsync();

            return true;
        }

        /// <summary>
        /// Get All
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<IQueryable<T>> GetAllAsync(Expression<Func<T, bool>>? expression = null)
        {
            return expression == null ? _dbSet : _dbSet.Where(expression);
        }

        /// <summary>
        /// Get
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<T> GetAsync(Expression<Func<T, bool>> expression)
        {
            return _dbSet.FirstOrDefaultAsync(expression);
        }

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<T> UpdateAsync(T entity)
        {
            var entry = _dbSet.Update(entity);

            await _dbContext.SaveChangesAsync();

            return entry.Entity;
        }
    }
}
