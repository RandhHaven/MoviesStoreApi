using StoreMovie.Api.Domain.Common;
using StoreMovie.Api.Domain.Entities;

namespace StoreMovie.Api.Domain.Events;

public class PromotionCreatedEvent : DomainEvent
{
    public PromotionCreatedEvent(Promotion item)
    {
        Item = item;
    }

    public Promotion Item { get; }
}
