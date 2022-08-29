using StoreMovie.Api.Application.Common.Exceptions;
using StoreMovie.Api.Application.PromotionApplication.Commands.CreatePromotion;
using StoreMovie.Api.Application.PromotionApplication.Commands.DeletePromotion;
using StoreMovie.Api.Domain.Entities;
using FluentAssertions;
using NUnit.Framework;
using StoreMovie.Application.IntegrationTests;

namespace StoreMovie.Api.Application.IntegrationTests.PromotionTest.Commands;

using static Testing;

public class DeletePromotionTests : TestBase
{
    [Test]
    public async Task ShouldRequireValidTodoListId()
    {
        var command = new DeletePromotionCommand { Id = Guid.NewGuid() };
        await FluentActions.Invoking(() => SendAsync(command)).Should().ThrowAsync<NotFoundException>();
    }

    [Test]
    public async Task ShouldDeleteTodoList()
    {
        var listId = await SendAsync(new CreatePromotionCommand
        {
            Active = true
        });

        await SendAsync(new DeletePromotionCommand
        {
            Id = listId
        });

        var list = await FindAsync<Promotion>(listId);

        list.Should().BeNull();
    }
}
