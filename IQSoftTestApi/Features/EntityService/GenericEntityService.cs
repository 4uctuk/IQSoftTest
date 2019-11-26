using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IQSoftTestApi.Features.DataContext;
using IQSoftTestApi.Features.DataContext.Model;
using Microsoft.EntityFrameworkCore;

namespace IQSoftTestApi.Features.EntityService
{
    public class GenericEntityService<T> : IEntityService<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext _context;

        protected virtual IQueryable<T> SetWithRelatedEntitiesAsNoTracking => _context.Set<T>().AsNoTracking();

        public GenericEntityService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<T>> GetAllEntities()
        {
            return await SetWithRelatedEntitiesAsNoTracking.OrderByDescending(c=>c.CreatedDateTime).ToListAsync();
        }

        public async Task DeleteEntity(int id)
        {
            var entity = await SetWithRelatedEntitiesAsNoTracking.FirstOrDefaultAsync(c => c.Id == id);
            if (entity == null)
            {
                throw new EntityNotFoundException<T>(id);
            }
            else
            {
                _context.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdateEntity(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<T> Get(int id)
        {
            var entity = await SetWithRelatedEntitiesAsNoTracking.FirstOrDefaultAsync(c => c.Id == id);
            if (entity == null)
            {
                throw new EntityNotFoundException<T>(id);
            }
            return entity;
        }
    }
}
