using System.Text.Json.Serialization;

namespace Json_exe.CrunchyrollAPIWrapper.Models.Response;

public sealed record ProfileResponse
{
    public string Avatar { get; init; } = string.Empty;

    [JsonPropertyName("cr_beta_opt_in")]
    public bool CrBetaOptIn { get; init; }

    [JsonPropertyName("crleg_email_verified")]
    public bool CrlegEmailVerified { get; init; }

    public string Email { get; init; } = string.Empty;

    [JsonPropertyName("extended_maturity_rating")]
    public ExtendedMaturityRating? ExtendedMaturityRating { get; init; }

    [JsonPropertyName("maturity_rating")] 
    public string MaturityRating { get; init; } = string.Empty;

    [JsonPropertyName("preferred_communication_language")]
    public string PreferredCommunicationLanguage { get; init; } = string.Empty;

    [JsonPropertyName("preferred_content_subtitle_language")]
    public string PreferredContentSubtitleLanguage { get; init; } = string.Empty;

    [JsonPropertyName("profile_name")]
    public string ProfileName { get; init; } = string.Empty;

    [JsonPropertyName("qa_user")]
    public bool QaUser { get; init; }

    public string Username { get; init; } = string.Empty;
}

public sealed record ExtendedMaturityRating
{
    [JsonPropertyName("BR")]
    public string Br { get; init; } = string.Empty;
}