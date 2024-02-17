using System.Net.Http.Headers;
using FluentAssertions;
using Json_exe.CrunchyrollAPIWrapper.Interfaces;
using Json_exe.CrunchyrollAPIWrapper.Models.Requests;
using Microsoft.Extensions.DependencyInjection;

namespace Json_exe.CrunchyrollAPIWrapper.Tests;

public class UnitTest1 : BaseTest
{
    [Fact]
    public async Task LoginAnonymousTest()
    {
        var crApi = ServiceProvider.GetRequiredService<ICrunchyrollApi>();
        var response = await crApi.LoginAnonymously(new LoginAnonymousRequest());
        response.IsSuccessStatusCode.Should().Be(true);
        response.Content.Should().NotBeNull();
        response.Content!.AccessToken.Should().NotBeEmpty();
        response.Content.TokenType.Should().Be("Bearer");
        response.Content.ExpiresIn.Should().BeGreaterThan(3000);
    }

    [Fact]
    public async Task LoginPasswordTest()
    {
        await LoginPassword();
    }

    [Fact]
    public async Task GetProfileTest()
    {
        var crApi = ServiceProvider.GetRequiredService<ICrunchyrollApi>();
        await LoginPassword();
        var profileResponse = await crApi.GetProfile(Token);
        profileResponse.IsSuccessStatusCode.Should().Be(true);
        profileResponse.Content.Should().NotBeNull();
        profileResponse.Content!.Email.Should().NotBeEmpty();
    }

    [Fact]
    public async Task LoginRefreshTokenTest()
    {
        var crApi = ServiceProvider.GetRequiredService<ICrunchyrollApi>();
        var data = await LoginPassword();
        var response = await crApi.LoginRefreshToken(new LoginRefreshTokenRequest
        {
            RefreshToken = data.RefreshToken!
        });
        response.IsSuccessStatusCode.Should().Be(true);
        response.Content.Should().NotBeNull();
        response.Content!.AccessToken.Should().NotBeEmpty();
        response.Content.RefreshToken.Should().NotBeNull().And.NotBeEmpty();
    }
}