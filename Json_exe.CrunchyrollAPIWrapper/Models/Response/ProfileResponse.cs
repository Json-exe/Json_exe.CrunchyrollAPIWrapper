using System.Text.Json.Serialization;

namespace Json_exe.CrunchyrollAPIWrapper.Models.Response;

public record ProfileResponse
{
    [JsonPropertyName("account_id")]
    public string AccountId { get; init; }

    [JsonPropertyName("external_id")]
    public string ExternalId { get; init; }

    [JsonPropertyName("email")]
    public string Email { get; init; }

    [JsonPropertyName("phone")]
    public string? Phone { get; init; }

    [JsonPropertyName("email_verified")]
    public bool EmailVerified { get; init; }

    [JsonPropertyName("has_password")]
    public bool HasPassword { get; init; }

    [JsonPropertyName("created")]
    public DateTime? Created { get; init; }
}