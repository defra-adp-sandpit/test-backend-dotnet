using FluentAssertions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using NSubstitute;

namespace Test.Backend.Dotnet.Api.Tests;

[TestFixture]
public class GlobalExceptionHandlerTests
{
    private readonly ILogger<GlobalExceptionHandler> _mockLogger;
    private readonly GlobalExceptionHandler _sut;

    public GlobalExceptionHandlerTests()
    {
        _mockLogger = Substitute.For<ILogger<GlobalExceptionHandler>>();
        _sut = new GlobalExceptionHandler(_mockLogger);
    }

    [Test]
    public async Task TryHandleAsync_Returns_True()
    {
        //Arrange
        var context = new DefaultHttpContext();
        var exception = new Exception("Error");
        var cancellationToken = new CancellationToken();

        //Act
        var result = await _sut.TryHandleAsync(context, exception, cancellationToken);

        //Assert
        result.Should().BeTrue();
    }

}
