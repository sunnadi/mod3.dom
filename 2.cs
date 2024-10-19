using System;

public class DatabaseConfig
{
    public string ConnectionString { get; }

    public DatabaseConfig()
    {
        ConnectionString = "Server=myServer;Database=myDb;UserId=myUser;Password=myPass;";
    }
}

public class DatabaseService
{
    private readonly DatabaseConfig _dbConfig;

    public DatabaseService(DatabaseConfig dbConfig)
    {
        _dbConfig = dbConfig;
    }

    public void Connect()
    {
        Console.WriteLine($"Подключение к базе данных с использованием строки: {_dbConfig.ConnectionString}");
    }
}

public class LoggingService
{
    private readonly DatabaseConfig _dbConfig;

    public LoggingService(DatabaseConfig dbConfig)
    {
        _dbConfig = dbConfig;
    }

    public void Log(string message)
    {
        Console.WriteLine($"Запись лога в базу данных: {message} с использованием строки: {_dbConfig.ConnectionString}");
    }
}

class Program
{
    static void Main()
    {
        var dbConfig = new DatabaseConfig();

        var databaseService = new DatabaseService(dbConfig);
        var loggingService = new LoggingService(dbConfig);

        databaseService.Connect();

        loggingService.Log("Это тестовое сообщение.");
    }
}
