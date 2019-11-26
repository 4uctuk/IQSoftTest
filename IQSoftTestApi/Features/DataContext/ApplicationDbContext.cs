using IQSoftTestApi.Features.DataContext.Model;
using Microsoft.EntityFrameworkCore;

namespace IQSoftTestApi.Features.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {}

        public DbSet<FirstTestEntity> FirstTestEntities { get; set; }

        public DbSet<SecondTestEntity> SecondTestEntities { get; set; }
    }
}
