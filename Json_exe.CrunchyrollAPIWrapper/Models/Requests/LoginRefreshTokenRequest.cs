using Json_exe.CrunchyrollAPIWrapper.Enums;
using Refit;

namespace Json_exe.CrunchyrollAPIWrapper.Models.Requests;

public sealed record LoginRefreshTokenRequest
{
    /// <summary>
    /// Sets the GrantType for the RefreshToken request. This has to be RefreshToken!
    /// </summary>
    [AliasAs("grant_type")]
    public GrantType GrantType { get; } = GrantType.RefreshToken;
    
    [AliasAs("scope")] public CrunchyrollScopes Scopes { get; } = CrunchyrollScopes.OfflineAccess;
    
    [AliasAs("refresh_token")] public required string RefreshToken { get; set; }
};