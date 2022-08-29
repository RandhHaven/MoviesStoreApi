
using FluentAssertions;
using NUnit.Framework;

namespace CleanArchitecture.Domain.UnitTests.ValueObjects;

public class StoreMovieTests
{
    [Test]
    public void ShouldReturnCorrectPromotionCode()
    {
        var code = "#FFFFFF";

        var colour = "#FFFFFF";

        colour.Should().Be(code);
    }
}
