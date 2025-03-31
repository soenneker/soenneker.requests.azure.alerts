using System.Text.Json.Serialization;

namespace Soenneker.Requests.Azure.Alerts;

/// <summary>
/// Represents a single dimension of a metric in an Azure alert.
/// Dimensions provide additional context for the metric, such as resource region or instance ID.
/// </summary>
public record CasDimension
{
    /// <summary>
    /// The name of the dimension (e.g., "ResourceName", "Region").
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The value associated with the dimension name.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}