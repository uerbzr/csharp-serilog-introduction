## 1. Introduction to Logging

### What is Logging?

- Logging is the process of capturing and storing information about an application's runtime behavior.
- It helps developers and system administrators to:
  - **Debug issues** during development.
  - **Monitor applications** in production environments.
  - **Audit actions** performed by a system or users.
  - **Analyze performance** for optimizing application behavior.

Logging provides visibility into how the application operates and helps identify potential bottlenecks or failures.

---

## 2. Common Logging Frameworks and Providers

Here are some popular logging libraries and frameworks available in .NET:

1. **Microsoft.Extensions.Logging** (Built-in in .NET):

   - A default logging framework in .NET Core and .NET 6/7/8+.
   - Supports multiple logging providers such as Console, Debug, EventLog, and TraceSource.
   - Integrates seamlessly with dependency injection and third-party providers.

2. **Serilog**:

   - A powerful library focused on **structured logging**, allowing logs to include rich, queryable data.
   - Offers support for multiple sinks like console, files, databases, and cloud services (e.g., Seq, Elasticsearch, Azure).
   - Provides an elegant and simple syntax for logging.

3. **log4net**:

   - A well-established library, widely used in legacy .NET applications.
   - Supports extensive configuration and a variety of output targets (appenders).

4. **Others**:
   - ElmahCore
   - NLOG

---

## 3. [Log Levels](LOGLEVELS.md)

# Serilog Log Levels

| **Level**       | **Value** | **Method Name**     | **Description**                                                     | **Use Case**                                      |
| --------------- | --------- | ------------------- | ------------------------------------------------------------------- | ------------------------------------------------- |
| **Verbose**     | 0         | `Log.Verbose()`     | Most detailed logs, including internal system messages.             | Deep debugging, high verbosity.                   |
| **Debug**       | 1         | `Log.Debug()`       | Diagnostic information for debugging purposes.                      | Used during development.                          |
| **Information** | 2         | `Log.Information()` | General application events to track the flow of execution.          | Insights into application behavior in production. |
| **Warning**     | 3         | `Log.Warning()`     | Indicates potential issues or unexpected behaviors.                 | Highlight areas that might need attention.        |
| **Error**       | 4         | `Log.Error()`       | Logs errors or exceptions where the application can still continue. | Failures requiring investigation and resolution.  |
| **Fatal**       | 5         | `Log.Fatal()`       | Critical issues leading to application termination.                 | Application crashes or irrecoverable errors.      |

# Microsoft Log Levels for ASP.NET Core

| Log Level       | Value | Method Name      | Description                                                                        |
| --------------- | ----- | ---------------- | ---------------------------------------------------------------------------------- |
| **Trace**       | 0     | `LogTrace`       | Logs detailed information for diagnosing issues. Typically used for debugging.     |
| **Debug**       | 1     | `LogDebug`       | Logs information useful for debugging. Less detailed than Trace.                   |
| **Information** | 2     | `LogInformation` | Logs general application flow and state. Suitable for production environments.     |
| **Warning**     | 3     | `LogWarning`     | Logs potential issues or unexpected events that don't interrupt the application.   |
| **Error**       | 4     | `LogError`       | Logs errors that prevent the application from functioning correctly.               |
| **Critical**    | 5     | `LogCritical`    | Logs critical issues causing application failure or requiring immediate attention. |
| **None**        | 6     | N/A              | Disables logging entirely.                                                         |
