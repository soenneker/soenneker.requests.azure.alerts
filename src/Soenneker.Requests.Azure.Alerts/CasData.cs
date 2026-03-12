using System.Text.Json.Serialization;

namespace Soenneker.Requests.Azure.Alerts;

/// <summary>
/// Represents the top-level data payload of an Azure alert using the Common Alert Schema (CAS).
/// Contains essential metadata and contextual information about the alert.
/// </summary>
public record CasData
{
    /// <summary>
    /// Core metadata about the alert, such as severity, alert rule, and affected resource.
    /// </summary>
    [JsonPropertyName("essentials")]
    public CasEssentials? Essentials { get; set; }

    /// <summary>
    /// Contextual details that describe why the alert was triggered, including condition and properties.
    /// </summary>
    [JsonPropertyName("alertContext")]
    public CasAlertContext? AlertContext { get; set; }
}