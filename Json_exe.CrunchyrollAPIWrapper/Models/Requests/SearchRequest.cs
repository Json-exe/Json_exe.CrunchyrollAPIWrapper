using Refit;

namespace Json_exe.CrunchyrollAPIWrapper.Models.Requests;

/// <summary>
/// Represents a search request to the Crunchyroll API.
/// </summary>
public record SearchRequest
{
    /// <summary>
    /// Gets or sets the query string for the search request.
    /// </summary>
    /// <value>The query string.</value>
    [AliasAs("q")]
    public required string Query { get; set; }
    
    /// <summary>
    /// Gets or sets the number of items to return in the search results.
    /// </summary>
    /// <value>The number of items.</value>
    [AliasAs("n")]
    public int? Items { get; set; }
    
    /// <summary>
    /// Gets or sets the starting index for the search results.
    /// </summary>
    /// <value>The starting index.</value>
    [AliasAs("start")]
    public int? Start { get; set; }
    
    /// <summary>
    /// Gets or sets the type of content to search for.
    /// </summary>
    /// <value>The type of content.</value>
    [AliasAs("type")]
    public Type? Type { get; set; }
    
    /// <summary>
    /// Gets or sets the categories to filter the search results.
    /// </summary>
    /// <value>The categories.</value>
    [AliasAs("categories")]
    public string[]? Categories { get; set; }
    
    /// <summary>
    /// Gets or sets the seasonal tag to filter the search results.
    /// </summary>
    /// <value>The seasonal tag.</value>
    [AliasAs("seasonal_tag")]
    public string? SeasonalTag { get; set; }
}