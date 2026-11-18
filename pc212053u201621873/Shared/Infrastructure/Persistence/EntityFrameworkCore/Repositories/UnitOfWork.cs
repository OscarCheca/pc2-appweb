using pc212053u201621873.Shared.Domain.Repositories;
using pc212053u201621873.Shared.Infrastructure.Persistence.EntityFrameworkCore.Configuration;

namespace pc212053u201621873.Shared.Infrastructure.Persistence.EntityFrameworkCore.Repositories;

public class UnitOfWork(AppDbContext context) : IUnitOfWork
{
    // inheritedDoc
    public async Task CompleteAsync(CancellationToken cancellationToken = default)
    {
        await context.SaveChangesAsync(cancellationToken);
    }
}