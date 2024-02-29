using System.Text.Json.Serialization;

namespace Json_exe.CrunchyrollAPIWrapper.Models;

public record CrunchyrollListResponse<T>
{
    [JsonPropertyName("total")]
    public int? Total { get; init; }
    
    [JsonPropertyName("meta")]
    public Meta Meta { get; init; }
    
    [JsonPropertyName("data")]
    public List<T> Data { get; init; }
};