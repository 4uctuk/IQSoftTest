using System;

namespace IQSoftTestApi.Features.EntityService
{
    public class EntityNotFoundException<TEntity> : Exception
    {
        public EntityNotFoundException(int id) : base($"{typeof(TEntity).Name} with id: {id} not found")
        {}
    }
}
