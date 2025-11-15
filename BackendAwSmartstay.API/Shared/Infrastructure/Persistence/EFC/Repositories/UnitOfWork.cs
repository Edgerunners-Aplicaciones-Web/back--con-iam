using BackendAwSmartstay.API.Shared.Domain.Repositories;
using BackendAwSmartstay.API.Shared.Infrastructure.Persistence.EFC.Configuration;

namespace BackendAwSmartstay.API.Shared.Infrastructure.Persistence.EFC.Repositories;


public class UnitOfWork(AppDbContext context) : IUnitOfWork
{
    // inheritedDoc
    public async Task CompleteAsync()
    {
        await context.SaveChangesAsync();
    }
}

