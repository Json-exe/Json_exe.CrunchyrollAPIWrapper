using System.Text.Json.Serialization;

namespace Json_exe.CrunchyrollAPIWrapper.Models.Response;

public sealed record SeriesResponse : CrunchyrollListResponse<CrunchyrollSeries>;