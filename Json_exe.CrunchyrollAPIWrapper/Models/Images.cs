using System.Text.Json.Serialization;

namespace Json_exe.CrunchyrollAPIWrapper.Models;

public sealed record Images
{
    public List<List<Thumbnail>> Thumbnail { get; init; } = [];
    
    [JsonPropertyName("poster_tall")] public List<List<Thumbnail>> PosterTall { get; init; }

    [JsonPropertyName("poster_wide")] public List<List<Thumbnail>> PosterWide { get; init; }
}