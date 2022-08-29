using StoreMovie.Api.Domain.Common;

namespace StoreMovie.Api.Application.Common.Interfaces;

public interface IDomainEventService
{
    Task Publish(DomainEvent domainEvent);
}