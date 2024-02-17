using Json_exe.CrunchyrollAPIWrapper.Enums;
using Refit;

namespace Json_exe.CrunchyrollAPIWrapper.Models.Requests;

public sealed record LoginPasswordRequest
{
    /// <summary>
    /// Sets the GrantType for the Password request. This has to be Password!
    /// </summary>
    [AliasAs("grant_type")]
    public GrantType GrantType { get; } = GrantType.Password;

    [AliasAs("scope")] public CrunchyrollScopes Scopes { get; } = CrunchyrollScopes.OfflineAccess;

    [AliasAs("username")] public required string Username { get; set; }

    [AliasAs("password")] public required string Password { get; set; }

    [AliasAs("device_id")] public string? DeviceId { get; set; }
}