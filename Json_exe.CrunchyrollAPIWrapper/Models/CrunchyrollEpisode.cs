using System.Text.Json.Serialization;
using Json_exe.CrunchyrollAPIWrapper.Models.Response;

namespace Json_exe.CrunchyrollAPIWrapper.Models;

public record CrunchyrollEpisode
{
    public string Id { get; init; }

    [JsonPropertyName("next_episode_id")] public string NextEpisodeId { get; init; }

    [JsonPropertyName("audio_locale")] public string AudioLocale { get; init; }

    public List<Version> Versions { get; init; } = [];

    public string Slug { get; init; }

    [JsonPropertyName("episode_number")] public int? EpisodeNumber { get; init; }

    [JsonPropertyName("premium_date")] public object PremiumDate { get; init; }

    [JsonPropertyName("subtitle_locales")] public List<string> SubtitleLocales { get; init; } = [];

    [JsonPropertyName("next_episode_title")]
    public string NextEpisodeTitle { get; init; }

    [JsonPropertyName("media_type")] public string MediaType { get; init; }

    [JsonPropertyName("channel_id")] public string ChannelId { get; init; }

    [JsonPropertyName("duration_ms")] public int? DurationMs { get; init; }

    [JsonPropertyName("availability_notes")]
    public string AvailabilityNotes { get; init; }

    public string Description { get; init; }

    [JsonPropertyName("available_date")] public object AvailableDate { get; init; }

    [JsonPropertyName("is_clip")] public bool IsClip { get; init; }

    [JsonPropertyName("eligible_region")] public string EligibleRegion { get; init; }

    [JsonPropertyName("closed_captions_available")]
    public bool? ClosedCaptionsAvailable { get; init; }

    [JsonPropertyName("series_id")] public string SeriesId { get; init; }

    [JsonPropertyName("series_title")] public string SeriesTitle { get; init; }

    [JsonPropertyName("season_slug_title")]
    public string SeasonSlugTitle { get; init; }

    [JsonPropertyName("maturity_ratings")] public List<string> MaturityRatings { get; init; } = [];

    [JsonPropertyName("is_dubbed")] public bool IsDubbed { get; init; }

    [JsonPropertyName("ad_breaks")] public List<AdBreak> AdBreaks { get; init; } = [];

    [JsonPropertyName("sequence_number")] public int? SequenceNumber { get; init; }

    [JsonPropertyName("season_sequence_number")]
    public int? SeasonSequenceNumber { get; init; }

    public string Title { get; init; }

    [JsonPropertyName("seo_description")] public string SeoDescription { get; init; }

    [JsonPropertyName("season_tags")] public List<object> SeasonTags { get; init; } = [];

    [JsonPropertyName("available_offline")]
    public bool AvailableOffline { get; init; }

    [JsonPropertyName("slug_title")] public string SlugTitle { get; init; }

    [JsonPropertyName("availability_starts")]
    public DateTime? AvailabilityStarts { get; init; }

    [JsonPropertyName("seo_title")] public string SeoTitle { get; init; }

    [JsonPropertyName("episode_air_date")] public DateTime? EpisodeAirDate { get; init; }

    [JsonPropertyName("episode")] public string Episode { get; init; }

    [JsonPropertyName("upload_date")] public DateTime? UploadDate { get; init; }

    [JsonPropertyName("free_available_date")]
    public DateTime? FreeAvailableDate { get; init; }

    [JsonPropertyName("is_subbed")] public bool IsSubbed { get; init; }

    [JsonPropertyName("streams_link")] public string StreamsLink { get; init; }

    [JsonPropertyName("premium_available_date")]
    public DateTime? PremiumAvailableDate { get; init; }

    [JsonPropertyName("is_premium_only")] public bool IsPremiumOnly { get; init; }

    [JsonPropertyName("listing_id")] public string ListingId { get; init; }

    [JsonPropertyName("extended_maturity_rating")]
    public ExtendedMaturityRating ExtendedMaturityRating { get; init; }

    [JsonPropertyName("series_slug_title")]
    public string SeriesSlugTitle { get; init; }

    [JsonPropertyName("season_title")] public string SeasonTitle { get; init; }

    [JsonPropertyName("mature_blocked")] public bool MatureBlocked { get; init; }

    public Images Images { get; init; }

    [JsonPropertyName("season_number")] public int? SeasonNumber { get; init; }

    [JsonPropertyName("production_episode_id")]
    public string ProductionEpisodeId { get; init; }

    [JsonPropertyName("is_mature")] public bool IsMature { get; init; }

    [JsonPropertyName("hd_flag")] public bool HdFlag { get; init; }

    public string Identifier { get; init; }

    [JsonPropertyName("season_id")] public string SeasonId { get; init; }

    [JsonPropertyName("availability_ends")]
    public DateTime? AvailabilityEnds { get; init; }
}