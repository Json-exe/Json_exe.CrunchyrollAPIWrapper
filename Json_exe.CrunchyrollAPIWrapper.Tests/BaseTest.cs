using FluentAssertions;
using Json_exe.CrunchyrollAPIWrapper.Interfaces;
using Json_exe.CrunchyrollAPIWrapper.Models.Requests;
using Json_exe.CrunchyrollAPIWrapper.Models.Response;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Xunit.Sdk;

namespace Json_exe.CrunchyrollAPIWrapper.Tests;

public class BaseTest
{
    protected readonly IServiceProvider ServiceProvider;
    protected string Token { get; private set; } = string.Empty;

    protected BaseTest()
    {
        var services = new ServiceCollection();
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("testsettings.json")
            .Build();
        services.AddCrunchyrollApiClients();
        services.AddSingleton<IConfiguration>(configuration);
        ServiceProvider = services.BuildServiceProvider();
    }

    protected async Task<LoginResponse> LoginPassword()
    {
        var crApi = ServiceProvider.GetRequiredService<ICrunchyrollApi>();
        var config = ServiceProvider.GetRequiredService<IConfiguration>();
        var response = await crApi.LoginPassword(new LoginPasswordRequest
        {
            Username = config.GetSection("Username").Value ?? throw new ArgumentNullException(),
            Password = config.GetSection("Password").Value ?? throw new ArgumentNullException()
        });
        response.IsSuccessStatusCode.Should().Be(true);
        response.Content.Should().NotBeNull();
        response.Content!.AccessToken.Should().NotBeEmpty();
        response.Content.TokenType.Should().Be("Bearer");
        response.Content.ExpiresIn.Should().BeGreaterThanOrEqualTo(300);
        response.Content.RefreshToken.Should().NotBeNull().And.NotBeEmpty();
        Token = $"{response.Content.TokenType} {response.Content.AccessToken}";
        return response.Content;
    }
}