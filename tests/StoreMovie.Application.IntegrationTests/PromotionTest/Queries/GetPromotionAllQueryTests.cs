using StoreMovie.Api.Application.PromotionApplication.Queries.GetAll;
using StoreMovie.Api.Domain.Entities;
using FluentAssertions;
using NUnit.Framework;
using StoreMovie.Application.IntegrationTests;

namespace StoreMovie.Api.Application.IntegrationTests.TodoLists.Queries;

using static Testing;

public class GetPromotionAllQueryTests : TestBase
{
    [Test]
    public async Task ShouldReturnAllListsPromotions()
    {
        await AddAsync(new Promotion
        {
            
        });

        var query = new GetPromotionAllQuery();

        var result = await SendAsync(query);

        result.ListPromotions.Should().HaveCount(5);
    }
}
