using System.Runtime.Serialization;

namespace Json_exe.CrunchyrollAPIWrapper.Models;

public enum Type
{
    [EnumMember(Value = "music")]
    Music,
    [EnumMember(Value = "series")]
    Series,
    [EnumMember(Value = "episode")]
    Episode,
    [EnumMember(Value = "top_results")]
    TopResults,
    [EnumMember(Value = "movie_listing")]
    MovieListing
}