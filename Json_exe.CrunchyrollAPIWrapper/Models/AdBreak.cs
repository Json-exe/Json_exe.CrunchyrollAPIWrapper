using System.Text.Json.Serialization;

namespace Json_exe.CrunchyrollAPIWrapper.Models;

public sealed record AdBreak
{
    [JsonPropertyName("offset_ms")] public int? OffsetMs { get; init; }

    public string Type { get; init; }
}