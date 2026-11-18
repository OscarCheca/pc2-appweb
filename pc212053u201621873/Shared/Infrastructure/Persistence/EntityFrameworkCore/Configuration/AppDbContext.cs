using Microsoft.EntityFrameworkCore;
using pc212053u201621873.Shared.Infrastructure.Persistence.EntityFrameworkCore.Configuration.Extensions;
using pc212053u201621873.Shared.Infrastructure.Persistence.EntityFrameworkCore.Interceptors;

namespace pc212053u201621873.Shared.Infrastructure.Persistence.EntityFrameworkCore.Configuration;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    /// <inheritdoc />
    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        // Apply audit timestamp interceptor for all IAuditableEntity implementations
        builder.AddInterceptors(new AuditableEntityInterceptor());
        base.OnConfiguring(builder);
    }


    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);


        // General Naming Convention for the database objects
        builder.UseSnakeCaseNamingConvention();
    }
}