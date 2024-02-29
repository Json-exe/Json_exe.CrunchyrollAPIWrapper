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
    Task<IApiResponse<ProfileMeResponse>> GetMeProfile([Header("Authorization")] string token);
    
    /// <summary>
    /// Retrieves the profile information of the authenticated user from the Crunchyroll API.
    /// </summary>
    /// <param name="token">The Bearer Authorization token obtained from a login request.</param>
    [Get("/accounts/v1/me")]
    Task<IApiResponse<ProfileResponse>> GetProfile([Header("Authorization")] string token);

    /// <summary>
    /// Retrieves the details of a specific episode from the Crunchyroll API.
    /// </summary>
    /// <param name="token">The Bearer Authorization token obtained from a login request.</param>
    /// <param name="episodeId">The unique identifier of the episode to retrieve.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the API response with the episode details.</returns>
    [Get("/content/v2/cms/episodes/{episodeId}")]
    Task<IApiResponse<EpisodeResponse>> GetEpisode([Header("Authorization")] string token, string episodeId);

    /// <summary>
    /// Retrieves the details of a specific series from the Crunchyroll API.
    /// </summary>
    /// <param name="token">The Bearer Authorization token obtained from a login request.</param>
    /// <param name="seriesId">The unique identifier of the series to retrieve.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the API response with the series details.</returns>
    [Get("/content/v2/cms/series/{seriesId}")]
    Task<IApiResponse<SeriesResponse>> GetSeries([Header("Authorization")] string token, string seriesId);

    /// <summary>
    /// Performs a search request to the Crunchyroll API.
    /// </summary>
    /// <param name="token">The Bearer Authorization token obtained from a login request.</param>
    /// <param name="request">The search request object containing the search parameters.</param>
    [Get("/content/v2/discover/search")]
    Task<IApiResponse<SearchResponse>> Search([Header("Authorization")] string token, SearchRequest request);
}