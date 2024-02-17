using System.Text.Json.Serialization;
using Json_exe.CrunchyrollAPIWrapper.Models.Response;

namespace Json_exe.CrunchyrollAPIWrapper.Models;

public record CrunchyrollEpisode
{
    public string Id { get; set; }

    [JsonPropertyName("next_episode_id")] public string NextEpisodeId { get; set; }

    [JsonPropertyName("audio_locale")] public string AudioLocale { get; set; }

    public List<Version> Versions { get; set; } = [];

    public string Slug { get; set; }

    [JsonPropertyName("episode_number")] public int? EpisodeNumber { get; set; }

    [JsonPropertyName("premium_date")] public object PremiumDate { get; set; }

    [JsonPropertyName("subtitle_locales")] public List<string> SubtitleLocales { get; set; } = [];

    [JsonPropertyName("next_episode_title")]
    public string NextEpisodeTitle { get; set; }

    [JsonPropertyName("media_type")] public string MediaType { get; set; }

    [JsonPropertyName("channel_id")] public string ChannelId { get; set; }

    [JsonPropertyName("duration_ms")] public int? DurationMs { get; set; }

    [JsonPropertyName("availability_notes")]
    public string AvailabilityNotes { get; set; }

    public string Description { get; set; }

    [JsonPropertyName("available_date")] public object AvailableDate { get; set; }

    [JsonPropertyName("is_clip")] public bool IsClip { get; set; }

    [JsonPropertyName("eligible_region")] public string EligibleRegion { get; set; }

    [JsonPropertyName("closed_captions_available")]
    public bool? ClosedCaptionsAvailable { get; set; }

    [JsonPropertyName("series_id")] public string SeriesId { get; set; }

    [JsonPropertyName("series_title")] public string SeriesTitle { get; set; }

    [JsonPropertyName("season_slug_title")]
    public string SeasonSlugTitle { get; set; }

    [JsonPropertyName("maturity_ratings")] public List<string> MaturityRatings { get; set; } = [];

    [JsonPropertyName("is_dubbed")] public bool IsDubbed { get; set; }

    [JsonPropertyName("ad_breaks")] public List<AdBreak> AdBreaks { get; set; } = [];

    [JsonPropertyName("sequence_number")] public int? SequenceNumber { get; set; }

    [JsonPropertyName("season_sequence_number")]
    public int? SeasonSequenceNumber { get; set; }

    public string Title { get; set; }

    [JsonPropertyName("seo_description")] public string SeoDescription { get; set; }

    [JsonPropertyName("season_tags")] public List<object> SeasonTags { get; set; } = [];

    [JsonPropertyName("available_offline")]
    public bool AvailableOffline { get; set; }

    [JsonPropertyName("slug_title")] public string SlugTitle { get; set; }

    [JsonPropertyName("availability_starts")]
    public DateTime? AvailabilityStarts { get; set; }

    [JsonPropertyName("seo_title")] public string SeoTitle { get; set; }

    [JsonPropertyName("episode_air_date")] public DateTime? EpisodeAirDate { get; set; }

    [JsonPropertyName("episode")] public string Episode { get; set; }

    [JsonPropertyName("upload_date")] public DateTime? UploadDate { get; set; }

    [JsonPropertyName("free_available_date")]
    public DateTime? FreeAvailableDate { get; set; }

    [JsonPropertyName("is_subbed")] public bool IsSubbed { get; set; }

    [JsonPropertyName("streams_link")] public string StreamsLink { get; set; }

    [JsonPropertyName("premium_available_date")]
    public DateTime? PremiumAvailableDate { get; set; }

    [JsonPropertyName("is_premium_only")] public bool IsPremiumOnly { get; set; }

    [JsonPropertyName("listing_id")] public string ListingId { get; set; }

    [JsonPropertyName("extended_maturity_rating")]
    public ExtendedMaturityRating ExtendedMaturityRating { get; set; }

    [JsonPropertyName("series_slug_title")]
    public string SeriesSlugTitle { get; set; }

    [JsonPropertyName("season_title")] public string SeasonTitle { get; set; }

    [JsonPropertyName("mature_blocked")] public bool MatureBlocked { get; set; }

    public Images Images { get; set; }

    [JsonPropertyName("season_number")] public int? SeasonNumber { get; set; }

    [JsonPropertyName("production_episode_id")]
    public string ProductionEpisodeId { get; set; }

    [JsonPropertyName("is_mature")] public bool IsMature { get; set; }

    [JsonPropertyName("hd_flag")] public bool HdFlag { get; set; }

    public string Identifier { get; set; }

    [JsonPropertyName("season_id")] public string SeasonId { get; set; }

    [JsonPropertyName("availability_ends")]
    public DateTime? AvailabilityEnds { get; set; }
}