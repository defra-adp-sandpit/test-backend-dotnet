﻿namespace Test.Backend.Dotnet.Api.Config;

public class AppInsightsConfig
{
    public required string ConnectionString { get; set; }
    public required string CloudRole { get; set; }
}

