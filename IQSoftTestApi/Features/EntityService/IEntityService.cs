using System.Collections.Generic;
using System.Threading.Tasks;
using IQSoftTestApi.Features.DataContext.Model;

namespace IQSoftTestApi.Features.EntityService
{
    public interface IEntityService<T>  where T : BaseEntity
    {
        Task<List<T>> GetAllEntities();

        Task DeleteEntity(int id);

        Task UpdateEntity(T entity);

        Task<T> Get(int id);
    }
}
