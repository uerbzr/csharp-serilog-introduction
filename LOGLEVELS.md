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

[Return](https://www.github.com/uerbzr/csharp-serilog-introduction)
