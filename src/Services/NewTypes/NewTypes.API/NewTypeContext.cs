using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Microsoft.eShopOnContainers.Services.NewTypes.NewTypes.API
{
    public class NewTypeContext : DbContext
    {
        public NewTypeContext(DbContextOptions<NewTypeContext> options) : base(options)
        {
        }

        public DbSet<NewType> NewTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new NewTypeEntityTypeConfiguration());
        }
    }


    public class NewTypeContextDesignFactory : IDesignTimeDbContextFactory<NewTypeContext>
    {
        public NewTypeContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<NewTypeContext>()
                .UseSqlServer("Server=.;Initial Catalog=Microsoft.eShopOnContainers.Services.CatalogDb;Integrated Security=true");

            return new NewTypeContext(optionsBuilder.Options);
        }
    }
}

