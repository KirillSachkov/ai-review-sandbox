using TextKit;
using Xunit;

namespace TextKit.Tests;

public class SlugifierTests
{
    [Theory]
    [InlineData("Hello World", "hello-world")]
    [InlineData("  Trim  Me  ", "trim-me")]
    [InlineData("", "")]
    [InlineData(null, "")]
    public void Slugify_Works(string? input, string expected)
        => Assert.Equal(expected, Slugifier.Slugify(input));
}
