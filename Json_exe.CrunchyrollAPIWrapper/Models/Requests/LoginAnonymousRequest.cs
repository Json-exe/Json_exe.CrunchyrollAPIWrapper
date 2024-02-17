using Json_exe.CrunchyrollAPIWrapper.Enums;
using Refit;

namespace Json_exe.CrunchyrollAPIWrapper.Models.Requests;

/// <summary>
/// The request to authenticate anonymously. Default parameters work.
/// </summary>
public sealed record LoginAnonymousRequest
{
    /// <summary>
    /// Sets the GrantType for the Anonymous request. This has to be ClientId!
    /// </summary>
    [AliasAs("grant_type")] public GrantType GrantType { get; set; } = GrantType.ClientId;
};