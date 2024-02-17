namespace Json_exe.CrunchyrollAPIWrapper.Models;

public record Thumbnail
{
    public int? Height { get; set; }

    public string Source { get; set; }

    public string Type { get; set; }

    public int? Width { get; set; }
}