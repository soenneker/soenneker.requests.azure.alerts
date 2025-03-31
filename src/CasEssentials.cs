using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Soenneker.Requests.Azure.Alerts;

/// <summary>
/// Represents the essential metadata of an Azure alert using the Common Alert Schema (CAS).
/// This section contains core information about the alert such as IDs, severity, and monitoring source.
/// </summary>
public record CasEssentials
{
    /// <summary>
    /// The unique identifier of the alert instance.
    /// </summary>
    [JsonPropertyName("alertId")]
    public string? AlertId { get; set; }

    /// <summary>
    /// The name or ID of the alert rule that triggered the alert.
    /// </summary>
    [JsonPropertyName("alertRule")]
    public string? AlertRule { get; set; }

    /// <summary>
    /// The severity level of the alert (e.g., Sev0, Sev1, Sev2).
    /// </summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>
    /// The type of signal that triggered the alert (e.g., Metric, Log, ActivityLog).
    /// </summary>
    [JsonPropertyName("signalType")]
    public string? SignalType { get; set; }

    /// <summary>
    /// Indicates whether the condition is currently met (e.g., Fired, Resolved).
    /// </summary>
    [JsonPropertyName("monitorCondition")]
    public string? MonitorCondition { get; set; }

    /// <summary>
    /// The monitoring service that generated the alert (e.g., Platform, Application Insights).
    /// </summary>
    [JsonPropertyName("monitoringService")]
    public string? MonitoringService { get; set; }

    /// <summary>
    /// A list of resource IDs that the alert targets.
    /// </summary>
    [JsonPropertyName("alertTargetIDs")]
    public List<string>? AlertTargetIDs { get; set; }

    /// <summary>
    /// A list of configuration items associated with the alert (e.g., virtual machines, resource groups).
    /// </summary>
    [JsonPropertyName("configurationItems")]
    public List<string>? ConfigurationItems { get; set; }

    /// <summary>
    /// The ID of the original alert if this alert is a duplicate or related instance.
    /// </summary>
    [JsonPropertyName("originAlertId")]
    public string? OriginAlertId { get; set; }

    /// <summary>
    /// The timestamp when the alert was fired.
    /// </summary>
    [JsonPropertyName("firedDateTime")]
    public string? FiredDateTime { get; set; }

    /// <summary>
    /// The timestamp when the alert was resolved (if applicable).
    /// </summary>
    [JsonPropertyName("resolvedDateTime")]
    public string? ResolvedDateTime { get; set; }

    /// <summary>
    /// A descriptive text explaining the alert.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The version of the essentials section format.
    /// </summary>
    [JsonPropertyName("essentialsVersion")]
    public string? EssentialsVersion { get; set; }

    /// <summary>
    /// The version of the alert context schema.
    /// </summary>
    [JsonPropertyName("alertContextVersion")]
    public string? AlertContextVersion { get; set; }
}
