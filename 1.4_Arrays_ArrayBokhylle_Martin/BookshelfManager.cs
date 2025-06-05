namespace _1._4_Arrays_ArrayBokhylle_Martin;

internal class BookshelfManager
{
    
    string[] _shelves = new string[10];
    public void Run()
    {
        WelcomeMessage();
        HandleInput();
    }
    private void WelcomeMessage()
    {
        Console.Clear();
        Console.WriteLine("This is my bookshelf!");
        Console.WriteLine("What would you like to do");
        Console.WriteLine("""
                          1) View all shelf contents
                          2) Add item to shelf
                          3) Exit
                          """);
    }
    private void HandleInput()
    {
        var choice = Console.ReadKey(true);

        switch (choice.Key)
        {
            case ConsoleKey.D1:
                ViewAllShelves();
                break;
            case ConsoleKey.D2:
                AddItemsToShelf();
                break;
            case ConsoleKey.D3:
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid input!");
                break;
        }
    }
    private void ViewAllShelves()
    {
        int index = 0;
        foreach (var shelf in _shelves)
        {
            index++;
            Console.WriteLine($"Shelf {index}: {shelf}");
        }
        Console.ReadLine();
    }
    private void AddItemsToShelf()
    {
        Console.WriteLine("Pick a shelf:");
        int index = 0;
        foreach (var shelf in _shelves)
        {
            index++;
            Console.WriteLine($"Shelf {index}: {shelf}");
        }
        var isNum = int.TryParse(Console.ReadLine(), out var inputChoice);

        if (isNum && inputChoice > 0 && inputChoice <= _shelves.Length)
        {
            Console.WriteLine("What would you like to add?");
            var input = Console.ReadLine();
            _shelves[inputChoice -1] = input;
        }
        
    }
}