using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using product.Infrastructure.Repository;

namespace product.WebApi
{
    public class RepositoryContextFactory : IDesignTimeDbContextFactory<RepositoryContext>
    {
        public RepositoryContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appSettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<RepositoryContext>()
                .UseSqlServer(configuration.GetConnectionString("sqlConnection"),
                b => b.MigrationsAssembly("product.WebApi"));

            return  new RepositoryContext(builder.Options);
        }
    }
}
