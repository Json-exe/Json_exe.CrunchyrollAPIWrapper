using System.Text.Json.Serialization;

namespace Json_exe.CrunchyrollAPIWrapper.Models;

public record Version
{
    [JsonPropertyName("audio_locale")]
    public string AudioLocale { get; init; }

    public string Guid { get; init; }

    [JsonPropertyName("is_premium_only")]
    public bool IsPremiumOnly { get; init; }

    [JsonPropertyName("media_guid")]
    public string MediaGuid { get; init; }

    public bool Original { get; init; }

    [JsonPropertyName("season_guid")]
    public string SeasonGuid { get; init; }

    public string Variant { get; init; }
}