using System.Text.Json.Serialization;

namespace Json_exe.CrunchyrollAPIWrapper.Models.Response;

public sealed record ProfileResponse
{
    public string Avatar { get; set; } = string.Empty;

    [JsonPropertyName("cr_beta_opt_in")]
    public bool CrBetaOptIn { get; set; }

    [JsonPropertyName("crleg_email_verified")]
    public bool CrlegEmailVerified { get; set; }

    public string Email { get; set; } = string.Empty;

    [JsonPropertyName("extended_maturity_rating")]
    public ExtendedMaturityRating? ExtendedMaturityRating { get; set; }

    [JsonPropertyName("maturity_rating")] 
    public string MaturityRating { get; set; } = string.Empty;

    [JsonPropertyName("preferred_communication_language")]
    public string PreferredCommunicationLanguage { get; set; } = string.Empty;

    [JsonPropertyName("preferred_content_subtitle_language")]
    public string PreferredContentSubtitleLanguage { get; set; } = string.Empty;

    [JsonPropertyName("profile_name")]
    public string ProfileName { get; set; } = string.Empty;

    [JsonPropertyName("qa_user")]
    public bool QaUser { get; set; }

    public string Username { get; set; } = string.Empty;
}

public sealed record ExtendedMaturityRating
{
    [JsonPropertyName("BR")]
    public string Br { get; set; } = string.Empty;
}