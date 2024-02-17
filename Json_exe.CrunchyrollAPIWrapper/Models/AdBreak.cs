using System.Text.Json.Serialization;

namespace Json_exe.CrunchyrollAPIWrapper.Models;

public record AdBreak
{
    [JsonPropertyName("offset_ms")] public int? OffsetMs { get; set; }

    public string Type { get; set; }
}