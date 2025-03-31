using System.Text.Json.Serialization;

namespace Soenneker.Requests.Azure.Alerts;

/// <summary>
/// Represents the context information for an Azure alert using the Common Alert Schema (CAS).
/// This includes details about the condition that triggered the alert and any additional custom properties.
/// </summary>
public record CasAlertContext
{
    /// <summary>
    /// A collection of additional alert-specific properties provided in the alert payload.
    /// This is typically a dynamic object containing key-value pairs set in the alert rule.
    /// </summary>
    [JsonPropertyName("properties")]
    public object? Properties { get; set; }

    /// <summary>
    /// The type of condition that triggered the alert.
    /// For example, "Metric", "Log", or "ActivityLog".
    /// </summary>
    [JsonPropertyName("conditionType")]
    public string? ConditionType { get; set; }

    /// <summary>
    /// Detailed information about the condition that caused the alert to fire.
    /// This includes metrics, thresholds, and evaluation results.
    /// </summary>
    [JsonPropertyName("condition")]
    public CasCondition? Condition { get; set; }
}