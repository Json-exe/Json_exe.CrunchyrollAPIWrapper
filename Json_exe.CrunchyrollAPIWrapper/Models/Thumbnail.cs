namespace Json_exe.CrunchyrollAPIWrapper.Models;

public sealed record Thumbnail
{
    public int? Height { get; init; }

    public string Source { get; init; }

    public string Type { get; init; }

    public int? Width { get; init; }
}