[![](https://img.shields.io/nuget/v/soenneker.requests.azure.alerts.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.requests.azure.alerts/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.requests.azure.alerts/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.requests.azure.alerts/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.requests.azure.alerts.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.requests.azure.alerts/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.requests.azure.alerts/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.requests.azure.alerts/actions/workflows/codeql.yml)

# Soenneker.Requests.Azure.Alerts

Represents the context information for an Azure alert using the Common Alert Schema (CAS). This includes details about the condition that triggered the alert and any additional custom properties.

## Install

```bash
dotnet add package Soenneker.Requests.Azure.Alerts
```

## What you get

- `CasAlertContext` — Represents the context information for an Azure alert using the Common Alert Schema (CAS). This includes details about the condition that triggered the alert and any additional custom properties.
- `CasAllOf` — Represents a single condition clause within an Azure metric alert. Used in the "allOf" array of a metric-based alert condition in the Common Alert Schema.
- `CasCondition` — Represents the condition that triggered an Azure alert in the Common Alert Schema (CAS). Defines the evaluation window and the individual metric-based conditions.
- `CasData` — Represents the top-level data payload of an Azure alert using the Common Alert Schema (CAS). Contains essential metadata and contextual information about the alert.
- `CasDimension` — Represents a single dimension of a metric in an Azure alert. Dimensions provide additional context for the metric, such as resource region or instance ID.
- `CasEssentials` — Represents the essential metadata of an Azure alert using the Common Alert Schema (CAS). This section contains core information about the alert such as IDs, severity, and monitoring source.
- `CasRequest` — Represents the root object of an Azure alert notification using the Common Alert Schema (CAS). Contains the schema version and the primary alert data payload.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `CasAlertContext.Properties` | A collection of additional alert-specific properties provided in the alert payload. This is typically a dynamic object containing key-value pairs set in the alert rule. | A collection of additional alert-specific properties provided in the alert payload. This is typically a dynamic object containing key-value pairs set in the alert rule. |
| `CasAlertContext.ConditionType` | The type of condition that triggered the alert. For example, "Metric", "Log", or "ActivityLog". | The type of condition that triggered the alert. For example, "Metric", "Log", or "ActivityLog". |
| `CasAlertContext.Condition` | Detailed information about the condition that caused the alert to fire. This includes metrics, thresholds, and evaluation results. | Detailed information about the condition that caused the alert to fire. This includes metrics, thresholds, and evaluation results. |
| `CasAllOf.MetricName` | The name of the metric that triggered the alert. | The name of the metric that triggered the alert. |
| `CasAllOf.MetricNamespace` | The namespace of the metric, identifying the source or category of the metric. | The namespace of the metric, identifying the source or category of the metric. |
| `CasAllOf.Operator` | The logical operator used to evaluate the metric against the threshold (e.g., "GreaterThan", "LessThan"). | The logical operator used to evaluate the metric against the threshold (e.g., "GreaterThan", "LessThan"). |
| `CasAllOf.Threshold` | The threshold value used for comparison against the metric. | The threshold value used for comparison against the metric. |
| `CasAllOf.TimeAggregation` | The aggregation method used to evaluate the metric over time (e.g., "Average", "Total", "Maximum"). | The aggregation method used to evaluate the metric over time (e.g., "Average", "Total", "Maximum"). |
| `CasAllOf.Dimensions` | The list of dimensions that further qualify the metric (e.g., region, instance ID). | The list of dimensions that further qualify the metric (e.g., region, instance ID). |
| `CasAllOf.MetricValue` | The actual metric value that was evaluated when the alert was triggered. | The actual metric value that was evaluated when the alert was triggered. |
| `CasCondition.WindowSize` | The evaluation window size over which the condition was assessed (e.g., "PT5M" for 5 minutes). | The evaluation window size over which the condition was assessed (e.g., "PT5M" for 5 minutes). |
| `CasCondition.AllOf` | A list of individual metric conditions that must all be true for the alert to fire. | A list of individual metric conditions that must all be true for the alert to fire. |
| `CasData.Essentials` | Core metadata about the alert, such as severity, alert rule, and affected resource. | Core metadata about the alert, such as severity, alert rule, and affected resource. |
| `CasData.AlertContext` | Contextual details that describe why the alert was triggered, including condition and properties. | Contextual details that describe why the alert was triggered, including condition and properties. |
| `CasDimension.Name` | The name of the dimension (e.g., "ResourceName", "Region"). | The name of the dimension (e.g., "ResourceName", "Region"). |
| `CasDimension.Value` | The value associated with the dimension name. | The value associated with the dimension name. |
| `CasEssentials.AlertId` | The unique identifier of the alert instance. | The unique identifier of the alert instance. |
| `CasEssentials.AlertRule` | The name or ID of the alert rule that triggered the alert. | The name or ID of the alert rule that triggered the alert. |
