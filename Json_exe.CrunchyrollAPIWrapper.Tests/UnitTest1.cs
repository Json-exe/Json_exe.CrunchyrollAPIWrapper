using FluentAssertions;
using Json_exe.CrunchyrollAPIWrapper.Interfaces;
using Json_exe.CrunchyrollAPIWrapper.Models.Requests;
using Microsoft.Extensions.DependencyInjection;
using Type = Json_exe.CrunchyrollAPIWrapper.Models.Type;

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
    public async Task GetMeProfileTest()
    {
        var crApi = ServiceProvider.GetRequiredService<ICrunchyrollApi>();
        await LoginPassword();
        var profileResponse = await crApi.GetMeProfile(Token);
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

    [Fact]
    public async Task GetSeriesTest()
    {
        var crApi = ServiceProvider.GetRequiredService<ICrunchyrollApi>();
        await LoginAnonymous();
        var response = await crApi.GetSeries(Token, "GDKHZEJ0K");
        response.IsSuccessStatusCode.Should().Be(true);
        response.Content.Should().NotBeNull();
        response.Content!.Data.Should().NotBeEmpty();
        var series = response.Content.Data.FirstOrDefault();
        series.Should().NotBeNull();
        series!.Id.Should().Be("GDKHZEJ0K");
        series.Images.PosterTall.Should().NotBeEmpty();
        series.Images.PosterWide.Should().NotBeEmpty();
        series.Keywords.Should().NotBeEmpty();
        series.AudioLocales.Should().NotBeEmpty();
        series.SubtitleLocales.Should().NotBeEmpty();
    }

    [Fact]
    public async Task GetProfileTest()
    {
        var crApi = ServiceProvider.GetRequiredService<ICrunchyrollApi>();
        await LoginPassword();
        var response = await crApi.GetProfile(Token);
        response.IsSuccessStatusCode.Should().BeTrue();
        response.Content.Should().NotBeNull();
        response.Content!.Created.Should().NotBeNull();
        response.Content.AccountId.Should().NotBeEmpty();
        response.Content.Email.Should().NotBeEmpty();
    }

    [Fact]
    public async Task SearchTest()
    {
        var crApi = ServiceProvider.GetRequiredService<ICrunchyrollApi>();
        await LoginAnonymous();
        var response = await crApi.Search(Token, new SearchRequest
        {
            Query = "One-Punch Man",
            Type = Type.Series,
            Items = 5
        });
        response.IsSuccessStatusCode.Should().BeTrue();
        response.Content.Should().NotBeNull();
        response.Content!.Data.Should().NotBeEmpty();
        response.Content.Data.First().Items.Should().NotBeEmpty();
        response.Content.Data.First().Items.First().Title.Should().Be("One-Punch Man");
        response.Content.Data.First().Items.First().SlugTitle.Should().Be("one-punch-man");
        response.Content.Data.First().Items.First().Id.Should().Be("G63K98PZ6");
    }
}