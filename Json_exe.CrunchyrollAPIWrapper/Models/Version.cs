using System.Text.Json.Serialization;

namespace Json_exe.CrunchyrollAPIWrapper.Models;

public record Version
{
    [JsonPropertyName("audio_locale")]
    public string AudioLocale { get; set; }

    public string Guid { get; set; }

    [JsonPropertyName("is_premium_only")]
    public bool IsPremiumOnly { get; set; }

    [JsonPropertyName("media_guid")]
    public string MediaGuid { get; set; }

    public bool Original { get; set; }

    [JsonPropertyName("season_guid")]
    public string SeasonGuid { get; set; }

    public string Variant { get; set; }
}