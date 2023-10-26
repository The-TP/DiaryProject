using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess
{
    public static class DatabaseContextSeed
    {
        public static void RunSeed(this IServiceProvider services)
        {
            using (var serviceScope = services.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<DatabaseContext>();

                // Seed the database.
                SeedDatabase(context);
            }
        }

        public static void SeedDatabase(DbContext dbContext)
        {
            // run seed here
        }
    }
}
