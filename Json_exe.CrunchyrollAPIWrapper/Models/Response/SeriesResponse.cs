using System.Text.Json.Serialization;

namespace Json_exe.CrunchyrollAPIWrapper.Models.Response;

public sealed record SeriesResponse
{
    [JsonPropertyName("total")]
    public int? Total { get; init; }

    [JsonPropertyName("data")]
    public List<CrunchyrollSeries> Data { get; init; }

    [JsonPropertyName("meta")]
    public Meta Meta { get; init; }
}