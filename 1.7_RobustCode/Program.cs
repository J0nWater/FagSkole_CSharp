using _1._7_RobustCode;

const string filePath = @"C:\Users\Jon\Documents\test.txt";
var fileManager = new FileManager(filePath);


while (true)
{
    Console.WriteLine("Available commands: create, write, read, delete, move");
    Console.Write("> ");
    var input = Console.ReadLine();
    switch (input)
    {
        case "read":
            Console.WriteLine(fileManager.ReadFileContent());
            break;
        case "create":
            fileManager.CreateFile();
            Console.WriteLine($"File {fileManager.FilePath} created");
            break;
        case "write":
            Console.WriteLine("Content:");
            var content = Console.ReadLine();
            fileManager.WriteFileContent(content);
            break;
        case "delete":
            fileManager.DeleteFile();
            Console.WriteLine($"File {fileManager.FilePath} deleted");
            break;
        case "move":
            Console.Write("New path: ");
            var newPath = Console.ReadLine();
            fileManager.MoveFile(newPath);
            break;
        case "exit":
            Environment.Exit(0);
            break;
    }
}