using StoreMovie.Api.Application.Common.Interfaces;

namespace StoreMovie.Api.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
