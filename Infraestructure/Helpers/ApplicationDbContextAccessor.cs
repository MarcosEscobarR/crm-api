using Core.Helpers;
using Core.Interfaces;
using Infraestructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Helpers;
public class ApplicationDbContextAccessor
{
    public readonly ApplicationDbContext Context;
    private readonly IIdentityService _identityService;

    public ApplicationDbContextAccessor(ApplicationDbContext context, IIdentityService identityService)
    {
        Context = context;
        _identityService = identityService;
    }

    private async Task UpdateAuditableEntities()
    {
        var changes = Context.ChangeTracker.Entries<AuditableEntity>();
        foreach (var entityEntry in changes)
        {
            switch (entityEntry.State)
            {
                case EntityState.Added:
                    entityEntry.Entity.CreatedAt = DateTime.Now.SetKindUtc();
                    // entityEntry.Entity.UserWhoCreated = await _identityService.GetCurrentUser();
                    entityEntry.Entity.UserWhoCreatedId = 1;
                    
                    break;
                case EntityState.Modified:
                    entityEntry.Entity.UpdatedAt = DateTime.Now.SetKindUtc();
                    // entityEntry.Entity.UserWhoModified = await _identityService.GetCurrentUser();
                    entityEntry.Entity.UserWhoModifiedId = 1;
                    break;
            }
        }
    }

    public async Task SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        // if (await _identityService.GetCurrentUser() is not null)
        // {
        //     await UpdateAuditableEntities();
        // }

        await UpdateAuditableEntities();
        await Context.SaveChangesAsync(cancellationToken);
    }
} 