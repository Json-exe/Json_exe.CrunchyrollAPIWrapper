namespace Json_exe.CrunchyrollAPIWrapper.Models;

public record Images
{
    public List<List<Thumbnail>> Thumbnail { get; set; } = [];
}