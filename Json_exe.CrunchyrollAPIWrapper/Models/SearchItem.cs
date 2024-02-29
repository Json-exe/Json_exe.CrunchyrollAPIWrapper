using System.Text.Json.Serialization;
using Json_exe.CrunchyrollAPIWrapper.Models.Response;

namespace Json_exe.CrunchyrollAPIWrapper.Models;

public record SearchItem
{
    [JsonPropertyName("slug")]
    public string Slug { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("external_id")]
    public string ExternalId { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("promo_description")]
    public string PromoDescription { get; set; }

    [JsonPropertyName("new")]
    public bool New { get; set; }

    [JsonPropertyName("channel_id")]
    public string ChannelId { get; set; }

    [JsonPropertyName("linked_resource_key")]
    public string LinkedResourceKey { get; set; }

    [JsonPropertyName("promo_title")]
    public string PromoTitle { get; set; }

    [JsonPropertyName("search_metadata")]
    public SearchMetadata SearchMetadata { get; set; }

    [JsonPropertyName("series_metadata")]
    public SeriesMetadata SeriesMetadata { get; set; }

    [JsonPropertyName("images")]
    public Images Images { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("slug_title")]
    public string SlugTitle { get; set; }
}

public sealed record SearchMetadata
{
    [JsonPropertyName("score")]
    public double Score { get; set; }
}

public sealed record SeriesMetadata
{
    [JsonPropertyName("audio_locales")]
    public List<string> AudioLocales { get; set; }

    [JsonPropertyName("availability_notes")]
    public string AvailabilityNotes { get; set; }

    [JsonPropertyName("episode_count")]
    public int EpisodeCount { get; set; }

    [JsonPropertyName("extended_description")]
    public string ExtendedDescription { get; set; }

    [JsonPropertyName("extended_maturity_rating")]
    public ExtendedMaturityRating ExtendedMaturityRating { get; set; }

    [JsonPropertyName("is_dubbed")]
    public bool IsDubbed { get; set; }

    [JsonPropertyName("is_mature")]
    public bool IsMature { get; set; }

    [JsonPropertyName("is_simulcast")]
    public bool IsSimulcast { get; set; }

    [JsonPropertyName("is_subbed")]
    public bool IsSubbed { get; set; }

    [JsonPropertyName("mature_blocked")]
    public bool MatureBlocked { get; set; }

    [JsonPropertyName("maturity_ratings")]
    public List<string> MaturityRatings { get; set; }

    [JsonPropertyName("season_count")]
    public int SeasonCount { get; set; }

    [JsonPropertyName("series_launch_year")]
    public int SeriesLaunchYear { get; set; }

    [JsonPropertyName("subtitle_locales")]
    public List<string> SubtitleLocales { get; set; }

    [JsonPropertyName("tenant_categories")]
    public List<string> TenantCategories { get; set; }

    [JsonPropertyName("awards")]
    public List<Award> Awards { get; set; }
}

public class Award
{
    [JsonPropertyName("icon_url")]
    public string IconUrl { get; set; }

    [JsonPropertyName("is_current_award")]
    public bool IsCurrentAward { get; set; }

    [JsonPropertyName("is_winner")]
    public bool IsWinner { get; set; }

    [JsonPropertyName("text")]
    public string Text { get; set; }
}