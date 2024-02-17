namespace Json_exe.CrunchyrollAPIWrapper.Models.Response;

public record EpisodeResponse
{
    public int? Total { get; init; }

    public List<CrunchyrollEpisode> Data { get; init; } = [];

    public Meta Meta { get; init; }
}