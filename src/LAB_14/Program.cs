using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
class LAB_14
{
    static void Main()
    {
        string[] fileNames = { "log1.txt", "log2.txt", "log3.txt" };
        CreateLogFiles(fileNames, 10000); 
        Task[] tasks = new Task[fileNames.Length];
        for (int i = 0; i < fileNames.Length; i++)
        {
            int fileIndex = i; 
            tasks[i] = Task.Run(() => ProcessFile(fileNames[fileIndex]));
        }
        Task.WhenAll(tasks).Wait();
        Console.WriteLine("File processing completed!");
    }
    static void CreateLogFiles(string[] fileNames, int linesPerFile)
    {
        Random rnd = new Random();
        foreach (var fileName in fileNames)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                for (int i = 0; i < linesPerFile; i++)
                {
                    if (rnd.Next(100) < 10)
                    {
                        writer.WriteLine("ERROR: Something went wrong!");
                    }
                    else
                    {
                        writer.WriteLine("INFO: Everything is working fine.");
                    }
                }
            }
        }
        Console.WriteLine("Files have been created successfully.");
    }
    static void ProcessFile(string fileName)
    {
        int errorCount = 0;
        try
        {
            var lines = File.ReadAllLines(fileName);
            foreach (var line in lines)
            {
                if (line.Contains("ERROR"))
                {
                    errorCount++;
                }
            }
            Console.WriteLine($"File {fileName}: Found {errorCount} errors.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error processing file {fileName}: {ex.Message}");
        }
    }
}