using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Soenneker.Requests.Azure.Alerts;

/// <summary>
/// Represents a single condition clause within an Azure metric alert.
/// Used in the "allOf" array of a metric-based alert condition in the Common Alert Schema.
/// </summary>
public record CasAllOf
{
    /// <summary>
    /// The name of the metric that triggered the alert.
    /// </summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>
    /// The namespace of the metric, identifying the source or category of the metric.
    /// </summary>
    [JsonPropertyName("metricNamespace")]
    public string? MetricNamespace { get; set; }

    /// <summary>
    /// The logical operator used to evaluate the metric against the threshold (e.g., "GreaterThan", "LessThan").
    /// </summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>
    /// The threshold value used for comparison against the metric.
    /// </summary>
    [JsonPropertyName("threshold")]
    public string? Threshold { get; set; }

    /// <summary>
    /// The aggregation method used to evaluate the metric over time (e.g., "Average", "Total", "Maximum").
    /// </summary>
    [JsonPropertyName("timeAggregation")]
    public string? TimeAggregation { get; set; }

    /// <summary>
    /// The list of dimensions that further qualify the metric (e.g., region, instance ID).
    /// </summary>
    [JsonPropertyName("dimensions")]
    public List<CasDimension>? Dimensions { get; set; }

    /// <summary>
    /// The actual metric value that was evaluated when the alert was triggered.
    /// </summary>
    [JsonPropertyName("metricValue")]
    public double? MetricValue { get; set; }
}