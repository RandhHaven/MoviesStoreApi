using MediatR;
using StoreMovie.Api.Application.Common.EntitiesDto;

namespace StoreMovie.Api.Application.PromotionApplication.Queries.GetByFilters;

public sealed class GetPromotionByIdQuery : IRequest<PromotionDto>
{
    public Guid Id { get; set; }
}
