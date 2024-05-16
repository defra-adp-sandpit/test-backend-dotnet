using Test.Backend.Dotnet.Api.HealthChecks;
using FluentAssertions;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace Test.Backend.Dotnet.Api.Tests.HealthChecksTests;

[TestFixture]
public class ReadinessCheckTests
{
    private readonly ReadinessCheck _sut = new();

    [Test]
    public async Task CheckHealthAsync_Returns_Healthy()
    {
        //Arrange
        var mockContext = new HealthCheckContext();
        var cancellationToken = new CancellationToken();

        //Act
        var result = await _sut.CheckHealthAsync(mockContext, cancellationToken);

        //Assert
        result.Should().BeEquivalentTo(HealthCheckResult.Healthy("OK"));
    }
}