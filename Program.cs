using System;

public class User
{
    public string Name { get; set; }
    public string Email { get; set; }

    public void SaveToDatabase()
    {
        Console.WriteLine($"Пользователь {Name} сохранен в базе данных.");
    }
}

public class FileReader
{
    public string ReadFile(string filePath)
    {
        Console.WriteLine($"Чтение файла: {filePath}");
        return "содержимое файла"; 
    }
}

public class ReportGenerator
{
    public void GeneratePdfReport()
    {
        Console.WriteLine("PDF отчет сгенерирован.");
    }
}

class Program
{
    static void Main()
    {
        User user = new User { Name = "Су Ди", Email = "sudi@example.com" };
        user.SaveToDatabase();

        FileReader fileReader = new FileReader();
        string content = fileReader.ReadFile("example.txt");
        Console.WriteLine(content);

        ReportGenerator reportGenerator = new ReportGenerator();
        reportGenerator.GeneratePdfReport();
    }
}
