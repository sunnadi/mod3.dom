using System;

public enum LogLevel
{
    Error,
    Warning,
    Info
}

public class Logger
{
    public void Log(string message, LogLevel level)
    {
        string logMessage = level switch
        {
            LogLevel.Error => $"ERROR: {message}",
            LogLevel.Warning => $"WARNING: {message}",
            LogLevel.Info => $"INFO: {message}",
            _ => message
        };

        Console.WriteLine(logMessage);
    }
}

class Program
{
    static void Main()
    {
        var logger = new Logger();

        logger.Log("Сообщение об ошибке", LogLevel.Error);
        logger.Log("Сообщение о предупреждении", LogLevel.Warning);
        logger.Log("Сообщение о информации", LogLevel.Info);
    }
}

