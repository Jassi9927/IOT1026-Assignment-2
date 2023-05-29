namespace Assignment
{
    static class Program
    {
        static void Main()
        {
            TreasureChest chest = new TreasureChest();
            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine(chest + "\n"); // Display initial state and properties
                Console.WriteLine("********** Treasure Chest Menu **********");
                Console.WriteLine("1. Open the chest");
                Console.WriteLine("2. Close the chest");
                Console.WriteLine("3. Lock the chest");
                Console.WriteLine("4. Unlock the chest");
                Console.WriteLine("5. Exit");
                Console.WriteLine("***************************************");
                Console.Write("Enter your choice (1-5): ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        chest.Manipulate(TreasureChest.Action.Open);
                        break;
                    case "2":
                        chest.Manipulate(TreasureChest.Action.Close);
                        break;
                    case "3":
                        chest.Manipulate(TreasureChest.Action.Lock);
                        break;
                    case "4":
                        chest.Manipulate(TreasureChest.Action.Unlock);
                        break;
                    case "5":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number from 1 to 5.");
                        break;
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
