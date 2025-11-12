using BackendAwSmartstay.API.shared.Infrastructure.Persistence.EFC.Configuration.Extensions;
using EntityFrameworkCore.CreatedUpdatedDate.Extensions;
using Microsoft.EntityFrameworkCore;

namespace BackendAwSmartstay.API.shared.Infrastructure.Persistence.EFC.Configuration;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        builder.AddCreatedUpdatedInterceptor();
        base.OnConfiguring(builder);
    }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        // Hotel Context
        //builder.ApplyPublishingConfiguration();

        // Profiles Context
        //builder.ApplyProfilesConfiguration();
        
        // IAM Context
        // TODO: Apply IAM configuration when available
        // builder.ApplyIAMConfiguration();
        
        // General Naming Convention for the database objects
        builder.UseSnakeCaseNamingConvention();
    }
}