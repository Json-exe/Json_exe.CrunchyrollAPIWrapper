using Json_exe.CrunchyrollAPIWrapper.Models.Requests;
using Json_exe.CrunchyrollAPIWrapper.Models.Response;
using Refit;

namespace Json_exe.CrunchyrollAPIWrapper.Interfaces;

public interface ICrunchyrollApi
{
    /// <summary>
    /// Logs in Anonymously to the Crunchyroll API. Not all features are available with this.
    /// </summary>
    /// <param name="loginAnonymousRequest"></param>
    [Post("/auth/v1/token")]
    [Headers([
        "Authorization: Basic Y3Jfd2ViOg=="
    ])]
    Task<IApiResponse<LoginResponse>> LoginAnonymously(
        [Body(BodySerializationMethod.UrlEncoded)] LoginAnonymousRequest loginAnonymousRequest);

    /// <summary>
    /// Logs in to the Crunchyroll API using a username and password.
    /// </summary>
    /// <param name="loginPasswordRequest">The request object containing the username and password.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the API response with the login response.</returns>
    /// <remarks>
    /// This method uses the POST HTTP method and the "/auth/v1/token" endpoint.
    /// The request body is URL encoded.
    /// The request includes an Authorization header with a Basic scheme. The credentials are base64 encoded.
    /// </remarks>
    [Post("/auth/v1/token")]
    [Headers([
        "Authorization: Basic b2VkYXJteHN0bGgxanZhd2ltbnE6OWxFaHZIWkpEMzJqdVY1ZFc5Vk9TNTdkb3BkSnBnbzE="
    ])]
    Task<IApiResponse<LoginResponse>> LoginPassword(
        [Body(BodySerializationMethod.UrlEncoded)] LoginPasswordRequest loginPasswordRequest);

    /// <summary>
    /// Logs in to the Crunchyroll API using a refresh token.
    /// </summary>
    /// <param name="refreshLoginRequest">The request object containing the refresh token.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the API response with the login response.</returns>
    /// <remarks>
    /// This method uses the POST HTTP method and the "/auth/v1/token" endpoint.
    /// The request body is URL encoded.
    /// The request includes an Authorization header with a Basic scheme. The credentials are base64 encoded.
    /// </remarks>
    [Post("/auth/v1/token")]
    [Headers([
        "Authorization: Basic b2VkYXJteHN0bGgxanZhd2ltbnE6OWxFaHZIWkpEMzJqdVY1ZFc5Vk9TNTdkb3BkSnBnbzE="
    ])]
    Task<IApiResponse<LoginResponse>> RefreshLogin(
        [Body(BodySerializationMethod.UrlEncoded)] RefreshLoginRequest refreshLoginRequest);
    
    /// <summary>
    /// Gets profile information for an account. Does not work with <see cref="LoginAnonymously"/>
    /// </summary>
    /// <param name="token">
    /// The Bearer Authorization token got from a login request.
    /// </param>
    [Get("/accounts/v1/me/profile")]
    Task<IApiResponse<ProfileResponse>> GetProfile([Header("Authorization")] string token);

    [Get("/content/v2/cms/episodes/{episodeId}")]
    Task<IApiResponse<List<EpisodeResponse>>> GetEpisode([Header("Authorization")] string token, string episodeId);
}