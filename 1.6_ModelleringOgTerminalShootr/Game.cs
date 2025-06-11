namespace _1._6_ModelleringOgTerminalShootr
{
    public class Game
    {
        public Player CurrentPlayer = null;
        public Weapon[] AvailableWeapons =
        [
            new("AK-47", 30),
            new("M4A1-S", 20),
            new("USP-S", 12),
            new("UMP-45", 25),
            new("P90", 50),
            new("Glock-18", 20),
            new("AWP", 5),
            new("SSG-08", 10)
        ];
        public Game()
        {
            Run();
        }

        private void Run()
        {
            while (true)
            {
                Console.WriteLine("xXxCommandLineShotahxXx");
                Console.WriteLine("""
                                  1) Create a player
                                  2) Check current weapons
                                  3) Pick weapon
                                  4) Exit
                                  """);
                HandleInput();
            }
        }

        private void HandleInput()
        {
            var input = Console.ReadKey(true);

            switch (input.Key)
            {
                case ConsoleKey.D1:
                    CreatePlayer();
                    break;
                case ConsoleKey.D2:
                    CheckCurrentWeapons();
                    break;
                case ConsoleKey.D3:
                    PickWeapon();
                    break;
                case ConsoleKey.D4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Wrong input.");
                    break;
            }
        }
        
        private void CreatePlayer()
        {
            CurrentPlayer = new Player(100, 100);
        }
        private void CheckCurrentWeapons()
        {
            if (CurrentPlayer == null)
            {
                Console.WriteLine("No player found.");
            }
            else
            {
                foreach (var weapon in CurrentPlayer.Weapons)
                {
                    Console.WriteLine($"Name: {weapon.Name} - Ammo: {weapon.Ammo}");
                }
            }
        }
        private void PickWeapon()
        {
            Console.WriteLine("Pick a weapon:");
            ShowAvailableWeapons();
            Console.WriteLine("Pick an item:");
            var input = Console.ReadLine();
        }

        private void ShowAvailableWeapons()
        {
            Console.WriteLine("Available weapons:");
            var index = 1;
            foreach (var weapon in AvailableWeapons)
            {
                Console.WriteLine($"{index}: Name: {weapon.Name} - Ammo: {weapon.Ammo}");
                index++;
            }
        }
    }
}