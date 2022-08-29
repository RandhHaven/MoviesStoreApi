using MediatR;
using StoreMovie.Api.Application.Common.EntitiesDto;
using StoreMovie.Api.Application.Common.Models;

namespace StoreMovie.Api.Application.PromotionApplication.Queries.GetAllPagination;

public class GetPromotionWithPagination : IRequest<PaginatedList<PromotionDto>>
{
    public int PageNumber { get; set; } = 1;
    public int PageSize { get; set; } = 10;
}
