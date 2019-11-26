using IQSoftTestApi.Features.DataContext;
using IQSoftTestApi.Features.DataContext.Model;
using IQSoftTestApi.Features.EntityService;

namespace IQSoftTestApi.Features.SecondEntity
{
    public class SecondEntityService : GenericEntityService<SecondTestEntity>, ISecondEntityService
    {
        public SecondEntityService(ApplicationDbContext context) : base(context)
        {
        }
    }
}
