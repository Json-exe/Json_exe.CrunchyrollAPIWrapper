namespace Json_exe.CrunchyrollAPIWrapper.Models.Response;

public record EpisodeResponse
{
    public int? Total { get; set; }

    public List<CrunchyrollEpisode> Data { get; set; } = [];

    public Meta Meta { get; set; }
}