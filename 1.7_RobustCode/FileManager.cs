namespace _1._7_RobustCode;

public class FileManager
{
    public string FilePath;

    public FileManager(string filePath)
    {
        var directory = Path.GetDirectoryName(filePath);
        if (!Directory.Exists(directory))
        {
            throw new ApplicationException("Directory doesn't exist");
        }
        FilePath = filePath;
    }

    public string ReadFileContent()
    {
        if (!File.Exists(FilePath))
        {
            return "File not found, create file";
        }

        try
        { 
            return File.ReadAllText(FilePath);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return string.Empty;
        }
    }

    public void CreateFile()
    {
        File.Create(FilePath).Close();
    }

    public void WriteFileContent(string content)
    {
        File.WriteAllText(FilePath, content);
    }

    public void MoveFile(string newPath)
    {
        File.Move(FilePath, newPath);
    }

    public void DeleteFile()
    {
        File.Delete(FilePath);
    }
}