using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Soenneker.Requests.Azure.Alerts;

/// <summary>
/// Represents the condition that triggered an Azure alert in the Common Alert Schema (CAS).
/// Defines the evaluation window and the individual metric-based conditions.
/// </summary>
public record CasCondition
{
    /// <summary>
    /// The evaluation window size over which the condition was assessed (e.g., "PT5M" for 5 minutes).
    /// </summary>
    [JsonPropertyName("windowSize")]
    public string? WindowSize { get; set; }

    /// <summary>
    /// A list of individual metric conditions that must all be true for the alert to fire.
    /// </summary>
    [JsonPropertyName("allOf")]
    public List<CasAllOf>? AllOf { get; set; }
}