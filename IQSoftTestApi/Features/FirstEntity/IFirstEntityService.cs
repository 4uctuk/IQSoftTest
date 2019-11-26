using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IQSoftTestApi.Features.DataContext.Model;
using IQSoftTestApi.Features.EntityService;

namespace IQSoftTestApi.Features.FirstEntity
{
    public interface IFirstEntityService : IEntityService<FirstTestEntity>
    {
    }
}
