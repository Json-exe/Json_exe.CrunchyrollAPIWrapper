using System.Text.Json.Serialization;

namespace Json_exe.CrunchyrollAPIWrapper.Models.Response;

public sealed record LoginResponse
{
    [JsonPropertyName("access_token")] public string AccessToken { get; set; } = string.Empty;

    [JsonPropertyName("refresh_token")] public string? RefreshToken { get; set; }

    [JsonPropertyName("expires_in")] public int? ExpiresIn { get; set; }

    [JsonPropertyName("token_type")] public string TokenType { get; set; } = string.Empty;

    public string Scope { get; set; } = string.Empty;

    public string Country { get; set; } = string.Empty;
    
    [JsonPropertyName("account_id")] public string? AccountId { get; set; }
    [JsonPropertyName("profile_id")] public string? ProfileId { get; set; }
}