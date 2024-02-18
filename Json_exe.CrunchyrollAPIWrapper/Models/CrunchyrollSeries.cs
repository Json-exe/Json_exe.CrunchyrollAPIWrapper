using System.Text.Json.Serialization;
using Json_exe.CrunchyrollAPIWrapper.Models.Response;

namespace Json_exe.CrunchyrollAPIWrapper.Models;

public sealed record CrunchyrollSeries
{
    [JsonPropertyName("availability_notes")]
        public string AvailabilityNotes { get; init; }

        [JsonPropertyName("episode_count")]
        public int? EpisodeCount { get; init; }

        [JsonPropertyName("is_subbed")]
        public bool IsSubbed { get; init; }

        [JsonPropertyName("title")]
        public string Title { get; init; }

        [JsonPropertyName("season_tags")]
        public List<string> SeasonTags { get; init; }

        [JsonPropertyName("seo_title")]
        public string SeoTitle { get; init; }

        [JsonPropertyName("slug")]
        public string Slug { get; init; }

        [JsonPropertyName("subtitle_locales")]
        public List<string> SubtitleLocales { get; init; }

        [JsonPropertyName("is_dubbed")]
        public bool IsDubbed { get; init; }

        [JsonPropertyName("is_mature")]
        public bool IsMature { get; init; }

        [JsonPropertyName("media_count")]
        public int? MediaCount { get; init; }

        [JsonPropertyName("extended_description")]
        public string ExtendedDescription { get; init; }

        [JsonPropertyName("season_count")]
        public int? SeasonCount { get; init; }

        [JsonPropertyName("seo_description")]
        public string SeoDescription { get; init; }

        [JsonPropertyName("series_launch_year")]
        public int? SeriesLaunchYear { get; init; }

        [JsonPropertyName("slug_title")]
        public string SlugTitle { get; init; }

        [JsonPropertyName("audio_locales")]
        public List<string> AudioLocales { get; init; }

        [JsonPropertyName("description")]
        public string Description { get; init; }

        [JsonPropertyName("id")]
        public string Id { get; init; }

        [JsonPropertyName("is_simulcast")]
        public bool IsSimulcast { get; init; }

        [JsonPropertyName("maturity_ratings")]
        public List<string> MaturityRatings { get; init; }

        [JsonPropertyName("content_provider")]
        public string ContentProvider { get; init; }

        [JsonPropertyName("mature_blocked")]
        public bool MatureBlocked { get; init; }

        [JsonPropertyName("channel_id")]
        public string ChannelId { get; init; }

        [JsonPropertyName("extended_maturity_rating")]
        public ExtendedMaturityRating ExtendedMaturityRating { get; init; }

        [JsonPropertyName("images")]
        public Images Images { get; init; }

        [JsonPropertyName("keywords")]
        public List<string> Keywords { get; init; }
};