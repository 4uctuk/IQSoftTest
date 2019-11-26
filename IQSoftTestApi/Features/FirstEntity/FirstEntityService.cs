using IQSoftTestApi.Features.DataContext;
using IQSoftTestApi.Features.DataContext.Model;
using IQSoftTestApi.Features.EntityService;

namespace IQSoftTestApi.Features.FirstEntity
{
    public class FirstEntityService : GenericEntityService<FirstTestEntity>, IFirstEntityService
    {
        public FirstEntityService(ApplicationDbContext context) : base(context)
        {
        }
    }
}
