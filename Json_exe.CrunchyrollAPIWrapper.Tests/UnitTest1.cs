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
        await LoginAnonymous();
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
        var response = await crApi.RefreshLogin(new RefreshLoginRequest
        {
            RefreshToken = data.RefreshToken!
        });
        response.IsSuccessStatusCode.Should().Be(true);
        response.Content.Should().NotBeNull();
        response.Content!.AccessToken.Should().NotBeEmpty();
        response.Content.RefreshToken.Should().NotBeNull().And.NotBeEmpty();
    }

    [Fact]
    public async Task GetEpisodeTest()
    {
        var crApi = ServiceProvider.GetRequiredService<ICrunchyrollApi>();
        await LoginAnonymous();
        var response = await crApi.GetEpisode(Token, "G9DUE5Q91");
        response.IsSuccessStatusCode.Should().Be(true);
        response.Content.Should().NotBeNull();
        response.Content!.Total.Should().BeGreaterThan(0);
        response.Content.Data.Should().NotBeEmpty();
        var episode = response.Content.Data.FirstOrDefault();
        episode.Should().NotBeNull();
        episode!.SeriesId.Should().Be("GY5P48XEY");
        episode.SeasonId.Should().Be("GY19CP0Z5");
        episode.Id.Should().Be("G9DUE5Q91");
        episode.Images.Thumbnail.Count.Should().BeGreaterThan(0);
    }
}