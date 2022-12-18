using System.Linq.Expressions;

namespace MockInterview.Infrastructure.IRepositories
{
    public interface IGenericRepository<T> where T : class
    {
        /// <summary>
        /// Create
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<T> CreateAsync(T entity);

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<T> UpdateAsync(T entity);

        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        Task<bool> DeleteAsync(Expression<Func<T, bool>> expression);

        /// <summary>
        /// Get All
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        Task<IQueryable<T>> GetAllAsync(Expression<Func<T, bool>>? expression = null);

        /// <summary>
        /// Get
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        Task<T> GetAsync(Expression<Func<T, bool>> expression);

    }
}
