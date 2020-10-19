using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AspDotNetCoreJwtAuthBlueprint.Models
{
    /*
     * https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext?view=efcore-3.1
     * https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.identity.entityframeworkcore.identitydbcontext-1?view=aspnetcore-3.0
     * 
     * A DbContext instance represents a session with the database and can be used to query and save instances of your entities. 
     * DbContext is a combination of the Unit Of Work and Repository patterns.
     * Typically you create a class that derives from DbContext and contains DbSet<TEntity> properties for each entity in the model.
     */
    public class AppDbContext : IdentityDbContext
    {
        /*
         * DbContextOptions will be injected automatically since we added 
         * services.AddDbContext<AppDbContext> in "ConfigureServices" method 
         */
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> AppUsers { get; set; }
    }
}
