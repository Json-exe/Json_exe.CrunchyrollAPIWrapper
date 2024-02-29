using System.Text.Json.Serialization;

namespace Json_exe.CrunchyrollAPIWrapper.Models;

public record SearchTypeResult
{
    [JsonPropertyName("type")]
    public Type Type { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("items")]
    public List<SearchItem> Items { get; set; }
};