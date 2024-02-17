using System.Text.Json.Serialization;

namespace Json_exe.CrunchyrollAPIWrapper.Models.Response;

public sealed record LoginResponse
{
    [JsonPropertyName("access_token")] public string AccessToken { get; init; } = string.Empty;

    [JsonPropertyName("refresh_token")] public string? RefreshToken { get; init; }

    [JsonPropertyName("expires_in")] public int? ExpiresIn { get; init; }

    [JsonPropertyName("token_type")] public string TokenType { get; init; } = string.Empty;

    public string Scope { get; init; } = string.Empty;

    public string Country { get; init; } = string.Empty;
    
    [JsonPropertyName("account_id")] public string? AccountId { get; init; }
    [JsonPropertyName("profile_id")] public string? ProfileId { get; init; }
}