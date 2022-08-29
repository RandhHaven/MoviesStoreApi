using MediatR;
using StoreMovie.Api.Application.Common.EntitiesDto;

namespace StoreMovie.Api.Application.PromotionApplication.Queries.GetByFilters;

public class GetPromotionValidityByDateQuery : IRequest<GetQueryDto>
{
    public DateTime? Date { get; set; } 
}
