using Microsoft.EntityFrameworkCore;
using SPMK.Core.Entity;
using SPMK.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPMK.Infra.Repository
{
    public abstract class CrudRepository<T> : ICrudReporitory<T> where T : BaseEntity
    {
        protected readonly DbContext _dbContext;
        protected readonly DbSet<T> _dbSet;

        protected CrudRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }

        public async void Dispose()
        {
            await _dbContext.DisposeAsync();
            GC.SuppressFinalize(this);
        }

        public async Task<T> GetById(string id)
        {
            var entity = await _dbSet
                .AsNoTracking()
                .SingleOrDefaultAsync(e => (e.Id == id));

            if (entity == null)
            {
                throw new InvalidOperationException("Entity not found");
            }

            return entity;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            var entities = await _dbSet
                .AsNoTracking()
                .ToListAsync();

            return entities;
        }

        public async Task<IEnumerable<T>> GetAllPaginated(
            int page,
            int quantityPerPage,
            string orderBy,
            string sortBy = "ASC"
        )
        {
            var entities = await _dbSet
                .AsNoTracking()
                .ToListAsync();

            return entities;
        }

        public async Task<T> Create(T entity)
        {
            entity.CreatedAt = DateTime.Now;
            entity.UpdatedAt = DateTime.Now;

            var newEntity = await _dbSet.AddAsync(entity);
            await _dbContext.SaveChangesAsync();

            return newEntity.Entity;
        }

        public async Task<T> DeleteById(string id)
        {
            T entity = await this.GetById(id);
            _dbSet.Remove(entity);
            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<T> UpdateById(string id, T updatedEntity)
        {
            _ = await GetById(id);

            T entity = updatedEntity;
            entity.UpdatedAt = DateTime.Now;

            _dbContext.Update(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }
    }
}
