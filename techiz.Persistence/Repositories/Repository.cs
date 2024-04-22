using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using techiz.Domain;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using techiz.Domain.Common;
using techiz.Domain.Interfaces;
using techiz.Persistence;
using Microsoft.Extensions.Logging;

namespace techiz.Persistence.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseSimpleModel
    {
        private readonly appDbContext _context;
        private DbSet<T> _dbSet;
        private readonly ILogger<Repository<T>> _logger;


        public Repository(appDbContext context, ILogger<Repository<T>> logger)
        {
            _context = context;
            _logger = logger;
            _dbSet = context.Set<T>();
        }
        
        public async Task<ResponseModel> AddAsync(T entity)
        {
            _logger.LogWarning($"Repository | Add : Start entity : {entity}");
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(AddAsync)} entity must not be null");
            }

            try
            {
                await _context.AddAsync(entity);
                var result = await _context.SaveChangesAsync();

                _logger.LogWarning($"Repository | Add : End-Success");
                return new ResponseModel(){ Success = true, Message = "Succeded",Data = entity.Id};
            }
            catch (Exception ex)
            {
                _logger.LogWarning($"Repository | Add : End-ERROR : {ex.InnerException.Message}");
                return new ResponseModel(){ Success = false, Message = "Error",Data = ex.InnerException.Message};
                //throw new Exception($"{nameof(entity)} could not be saved: {ex.Message}");
            }
        }

        public async Task<ResponseModel> DeleteAsync(T entity)
        {
            try
            {
                if (_context.Entry(entity).State == EntityState.Detached)
                    _dbSet.Attach(entity);

                _dbSet.Remove(entity);
                await _context.SaveChangesAsync();
                return new ResponseModel(){ Success = true, Message = "Succeded",Data = entity.Id};
            }
            catch (Exception ex)
            {
                return new ResponseModel(){ Success = false, Message = "Error",Data = ex.InnerException.Message};
            }
        }
        
        // public EntityList<T> GetAll(
        //     Expression<Func<T, bool>> filter = null,
        //     Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
        //     IEnumerable<Expression<Func<T, object>>> includes = null,
        //     int? page = null, int? pageSize = null)
        // {
        //     var query = _context.Set<T>().AsQueryable();
        //     if (includes != null)
        //     {
        //         query = includes.Aggregate(query, (current, include) => current.Include(include));
        //     }
        //
        //     int totalCount = query.Count();
        //     int filteredCount = totalCount;
        //
        //     if (filter != null)
        //     {
        //         query = query.AsExpandable().Where(filter);
        //         filteredCount = query.Count();
        //     }
        //
        //     if (orderBy != null)
        //     {
        //         query = orderBy(query);
        //     }
        //     if (page != null && pageSize != null)
        //     {
        //         query = query.Skip((page.Value - 1) * pageSize.Value).Take(pageSize.Value);
        //     }
        //
        //     var pageData = query.ToList();
        //
        //     return new EntityList<T>
        //     {
        //         TotalCount = totalCount,
        //         FilteredCount = filteredCount,
        //         PageData = pageData,
        //     };
        // }

        public async Task<ResponseModel> DeleteAsync(int id)
        {
            try
            {
                var entity = await GetAsync(id);
                await DeleteAsync(entity);
                await _context.SaveChangesAsync();
                
                return new ResponseModel(){ Success = true, Message = "Succeded",Data = entity.Id};
            }
            catch (Exception e)
            {
                return new ResponseModel(){ Success = false, Message = "Error",Data = e.InnerException.Message};
            }
        }

        public Task<IQueryable<T>> GetAllAsync()
        {
            return this.GetAllAsync(null, null, null, null, null);
        }

        public Task<IQueryable<T>> GetAllAsync(Expression<Func<T, bool>> predicate)
        {
            return this.GetAllAsync(predicate, null, null, null, null);
        }

        public Task<IQueryable<T>> GetAllAsync(Func<IQueryable<T>, IIncludableQueryable<T, object>> include)
        {
            return this.GetAllAsync(null, include, null, null, null);
        }
      public Task<IQueryable<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null,
                                                 Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null,
                                                 Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                                 int? skip = null, int? take = null)
        {
            IQueryable<T> query = GetQueryable(predicate, include);

            if (orderBy != null)
            {
                query = orderBy(query);
            }

            if (skip != null && skip.HasValue)
            {
                query = query.Skip(skip.Value);
            }

            if (take != null && take.HasValue)
            {
                query = query.Take(take.Value);
            }

            return new Task<IQueryable<T>>(() => query);
        }

        public Task<IQueryable<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null,
                                                Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null)
        {
            return new Task<IQueryable<T>> (() => GetQueryable(predicate, include)); 
        }

        public Task<IQueryable<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null,
         Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null,
        string orderBy = null, string orderDirection = "asc",
         int? skip = null, int? take = null)
        {
            IQueryable<T> query = GetQueryable(predicate, include);

            if (orderBy != null)
            {
                //query = query.OrderBy(orderBy, orderDirection);
            }

            if (skip != null && skip.HasValue)
            {
                query = query.Skip(skip.Value);
            }

            if (take != null && take.HasValue)
            {
                query = query.Take(take.Value);
            }

            return new Task<IQueryable<T>>(() => query);
        }

        
        /// <summary>
        /// Gets the first or default entity based on a predicate, orderby delegate and include delegate. This method default no-tracking query.
        /// </summary>
        /// <param name="selector">The selector for projection.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <param name="orderBy">A function to order elements.</param>
        /// <param name="include">A function to include navigation properties</param>
        /// <param name="disableTracking"><c>True</c> to disable changing tracking; otherwise, <c>false</c>. Default to <c>true</c>.</param>
        /// <returns>An <see cref="IPagedList{TEntity}"/> that contains elements that satisfy the condition specified by <paramref name="predicate"/>.</returns>
        /// <remarks>This method default no-tracking query.</remarks>
        public TResult GetFirstOrDefault<TResult>(Expression<Func<T, TResult>> selector,
            Expression<Func<T, bool>> predicate = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null,
            bool disableTracking = true)
        {
            IQueryable<T> query = _dbSet;
            if (disableTracking)
            {
                query = query.AsNoTracking();
            }

            if (include != null)
            {
                query = include(query);
            }

            if (predicate != null)
            {
                query = query.Where(predicate);
            }

            if (orderBy != null)
            {
                return orderBy(query).Select(selector).FirstOrDefault();
            }
            else
            {
                return query.Select(selector).FirstOrDefault();
            }
        }
        
        /// <summary>
        /// Returns a single instance of T but throws exception if none is found
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public T GetSingle(
         Expression<Func<T, bool>> predicate = null,
         Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null)
        {
            IQueryable<T> query = GetQueryable(predicate, include);
        
            return query.FirstOrDefault();
        }

        public Task<T> GetSingleAsync(
          Expression<Func<T, bool>> predicate = null,
          Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null)
        {
            IQueryable<T> query = GetQueryable(predicate, include);

            return query.FirstOrDefaultAsync();
        }
        private IQueryable<T> GetQueryable(Expression<Func<T, bool>> predicate = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null)
        {
            IQueryable<T> query = _context.Set<T>();

            if (include != null)
            {
                query = include(query);
            }

            if (predicate != null)
            {
                query = query.Where(predicate);
            }

            return query;
        }

        public async Task<IEnumerable<T>> GetWhereAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.Where(predicate).ToListAsync();
        }

        public async Task<T> GetAsync(int id)
        {
            var entity = await _dbSet.FindAsync(id);

            return entity;
        }

        public async Task<ResponseModel> UpdateAsync(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(AddAsync)} entity must not be null");
            }

            try
            {
                _dbSet.Attach(entity);
                _context.Entry(entity).State = EntityState.Modified;

                await _context.SaveChangesAsync();
                return new ResponseModel(){ Success = true, Message = "Succeded",Data = entity.Id};
            }
            catch (Exception ex)
            {
                return new ResponseModel(){ Success = false, Message = "Error",Data = ex.InnerException.Message};
                //throw new Exception($"{nameof(entity)} could not be saved: {ex.Message}");
            }
        }
        
        private bool _disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            try
            {
                if (!_disposed)
                {
                    if (disposing)
                    {
                        _context.Dispose();
                    }
                }
                _disposed = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
          
            }
          
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}