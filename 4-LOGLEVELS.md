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

## Resources

For more details, visit the [Microsoft Learn documentation](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/logging/?view=aspnetcore-9.0).
