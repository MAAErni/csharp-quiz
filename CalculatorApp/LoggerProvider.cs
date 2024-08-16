using Microsoft.Extensions.Logging;

namespace CalculatorApp;

public static class LoggerProvider
{
    public static ILoggerFactory loggerFactory = LoggerFactory.Create(
    builder => builder
                .AddConsole()
                .AddDebug()
    );

    public static ILogger CreateLogger<T>()
    {
        var logger = loggerFactory.CreateLogger<T>();
        return logger;
    }
}