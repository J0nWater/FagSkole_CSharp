namespace _1._6_ModelleringOgTerminalShootr
{
    public class Player
    {
        public int Health;
        public int Armor;
        public Weapon[] Weapons;

        public Player(int health, int armor)
        {
            Health = health;
            Armor = armor;
            Weapons = 
            [
                new Weapon("Empty", 0),
                new Weapon("Empty", 0),
                new Weapon("Empty", 0),
                new Weapon("Empty", 0),
                new Weapon("Empty", 0)
            ];
        }
    }
}