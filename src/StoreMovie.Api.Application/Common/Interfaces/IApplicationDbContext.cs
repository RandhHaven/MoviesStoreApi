namespace StoreMovie.Api.Application.Common.Interfaces;

using StoreMovie.Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

public interface IApplicationDbContext
{
    DbSet<Promotion> Promotions { get; }
    //DbSet<PromotionConfigure> PromotionsConfigure { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}