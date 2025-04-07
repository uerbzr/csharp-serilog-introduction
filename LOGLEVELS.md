## Serilog Logging Levels

| **Level**       | **Value** | **Method Name**     | **Description**                                                     | **Use Case**                                      |
| --------------- | --------- | ------------------- | ------------------------------------------------------------------- | ------------------------------------------------- |
| **Verbose**     | 0         | `Log.Verbose()`     | Most detailed logs, including internal system messages.             | Deep debugging, high verbosity.                   |
| **Debug**       | 1         | `Log.Debug()`       | Diagnostic information for debugging purposes.                      | Used during development.                          |
| **Information** | 2         | `Log.Information()` | General application events to track the flow of execution.          | Insights into application behavior in production. |
| **Warning**     | 3         | `Log.Warning()`     | Indicates potential issues or unexpected behaviors.                 | Highlight areas that might need attention.        |
| **Error**       | 4         | `Log.Error()`       | Logs errors or exceptions where the application can still continue. | Failures requiring investigation and resolution.  |
| **Fatal**       | 5         | `Log.Fatal()`       | Critical issues leading to application termination.                 | Application crashes or irrecoverable errors.      |

## Microsoft Logging Levels

| **Level**       | **Value** | **Method Name**    | **Description**                                                                |
| --------------- | --------- | ------------------ | ------------------------------------------------------------------------------ |
| **Trace**       | 0         | `LogTrace()`       | Used for very detailed debugging or tracing information.                       |
| **Debug**       | 1         | `LogDebug()`       | Diagnostic information useful for debugging purposes.                          |
| **Information** | 2         | `LogInformation()` | General application events to track the flow of execution.                     |
| **Warning**     | 3         | `LogWarning()`     | Indicates potential issues or unexpected behaviors.                            |
| **Error**       | 4         | `LogError()`       | Logs errors or exceptions where the application can still continue.            |
| **Critical**    | 5         | `LogCritical()`    | Logs fatal errors that require immediate attention or application termination. |
| **None**        | -1        | N/A                | Disables logging entirely for the category.                                    |
