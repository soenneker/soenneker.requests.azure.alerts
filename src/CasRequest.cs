using System.Text.Json.Serialization;

namespace Soenneker.Requests.Azure.Alerts;

/// <summary>
/// Represents the root object of an Azure alert notification using the Common Alert Schema (CAS).
/// Contains the schema version and the primary alert data payload.
/// </summary>
public record CasRequest
{
    /// <summary>
    /// The version identifier of the Common Alert Schema used in this alert payload.
    /// </summary>
    [JsonPropertyName("schemaId")]
    public string? SchemaId { get; set; }

    /// <summary>
    /// The main body of the alert, including essentials and context information.
    /// </summary>
    [JsonPropertyName("data")]
    public CasData? Data { get; set; }
}