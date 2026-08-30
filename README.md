[![](https://img.shields.io/nuget/v/soenneker.requests.azure.alerts.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.requests.azure.alerts/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.requests.azure.alerts/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.requests.azure.alerts/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.requests.azure.alerts.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.requests.azure.alerts/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.requests.azure.alerts/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.requests.azure.alerts/actions/workflows/codeql.yml)

# Soenneker.Requests.Azure.Alerts

DTOs for receiving Azure Monitor webhook notifications that use the Common Alert Schema (CAS).

## Installation

```bash
dotnet add package Soenneker.Requests.Azure.Alerts
```

## Usage

Use `CasRequest` as the request body for an ASP.NET Core webhook endpoint:

```csharp
using Soenneker.Requests.Azure.Alerts;

app.MapPost("/webhooks/azure-alerts", (CasRequest request) =>
{
    CasEssentials? alert = request.Data?.Essentials;

    if (alert is null)
        return Results.BadRequest();

    if (alert.MonitorCondition == "Fired")
    {
        logger.LogWarning(
            "Azure alert {AlertRule} fired with severity {Severity} for {Targets}",
            alert.AlertRule,
            alert.Severity,
            alert.AlertTargetIDs);
    }

    return Results.Ok();
});
```

For metric alerts, the evaluated clauses are available through the alert context:

```csharp
IEnumerable<CasAllOf> clauses =
    request.Data?.AlertContext?.Condition?.AllOf ?? [];

foreach (CasAllOf clause in clauses)
{
    Console.WriteLine(
        $"{clause.MetricNamespace}/{clause.MetricName}: " +
        $"{clause.MetricValue} {clause.Operator} {clause.Threshold}");
}
```

## Model shape

- `CasRequest` is the webhook envelope and contains `SchemaId` and `Data`.
- `CasEssentials` contains common metadata such as the rule, severity, monitor condition, target resource IDs, and fired/resolved timestamps.
- `CasAlertContext` contains signal-specific details. Its `Condition` models metric conditions; `Properties` remains an `object` because Azure can supply an arbitrary property shape.
- `CasCondition`, `CasAllOf`, and `CasDimension` represent metric evaluation details.

Azure emits different context shapes for metric, log, activity-log, and other alert types, so model members are nullable. When deserializing with `System.Text.Json`, `CasAlertContext.Properties` will normally be a `JsonElement`; inspect or deserialize it into an application-specific type before use.
