namespace _2._3P
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool finished = false;

            Console.WriteLine("Enter player's name: ");
            string playerName = Console.ReadLine();

            Console.WriteLine("Enter player's description: ");
            string desc = Console.ReadLine();
           
            Path path = new Path(new string[] { "path", "exit" }, new Location(new string[] {"toilet"}, "the Toilet", "a stinky place", null), new Direction[] { Direction.SOUTH });
            Location loc = new Location(new string[] { "hall", "hallway" }, "the Hallway", "a well lit Hallway", path);
            Player player = new Player(playerName, desc, loc);
            CommandProcessor processor = new CommandProcessor();

            Item sword = new Item(new string[] { "sword" }, "a bronze sword", "this is a good one...");
            Item shovel = new Item(new string[] { "shovel", "spade" }, "a shovel", "this is a might fine...");
            Item gem = new Item(new string[] { "gem" }, "a gem", "A bright red...");
            Item pencil = new Item(new string[] { "pencil" }, "a pencil", "a wooden pencil");
            Bag bag = new Bag(new string[] { "bag", "rucksack" }, "leather bag", "the best item to travel with...");

            player.Inventory.Put(sword);
            player.Inventory.Put(shovel);
            player.Inventory.Put(bag);
            bag.Inventory.Put(gem);
            loc.Inventory.Put(pencil);

            Console.Clear();
            Console.WriteLine("Welcome to SwinAdventure!");
            Console.WriteLine("You have arrived in " + loc.Name);

            while (!finished)
            {
                Console.WriteLine("Command: ");
                string command = Console.ReadLine();
                if (command.ToLower() == "quit")
                {
                    finished = true;
                } else
                {
                    Console.WriteLine(processor.Execute(player, command));
                }
                
                
            }

        }
    }
}