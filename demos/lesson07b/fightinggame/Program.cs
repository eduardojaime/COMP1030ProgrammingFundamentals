namespace fightinggame;
class Program
{
    static void Main(string[] args)
    {
        // Considerations:
        // I will start with single file
        // Rules:
        // Knight vs Monster
        // Every turn player will choose to attack (A) or heal (H)
        // Every turn Monster will attack the player or heal itself
        // In order to win the player must have more health than the monster

        // Instructions
        Console.WriteLine("Welcome to Monster Fight!!");
        Console.WriteLine("In this adventure you are playing the Knight!");
        Console.WriteLine("Many monsters live in this land so be careful!");
        Console.WriteLine("This is a turn based game, so you can choose to Attack or Heal");
        Console.WriteLine("");

        // Input
        int knightHP = 100; // health points
        int monsterHP = 100; // initial health value

        Console.WriteLine("A Monster has appeared! Prepare to fight!");
        int gameCounter = 5;
        while (gameCounter > 0)
        {
            // Process
            Console.WriteLine("Do you wish to attack (A), or heal (H)?");
            string userSelection = Console.ReadLine();
            // mock monster choice
            string monsterSelection = "A";

            // Battle
            if (userSelection == "A")
            {
                Console.WriteLine("You used your sword to attack!");
                monsterHP = monsterHP - 20;
            }
            else if (userSelection == "H")
            {
                Console.WriteLine("You used one of your magic potions!");
                knightHP = knightHP + 20;
            }
            else
            {
                Console.WriteLine("The Knight looks confused!");
            }

            if (monsterSelection == "A")
            {
                Console.WriteLine("The Monster used their club to attack!");
                knightHP = knightHP - 20;
            }
            else if (monsterSelection == "H")
            {
                Console.WriteLine("The Monster used a magic mushroom!");
                monsterHP = monsterHP + 20;
            }
            else
            {
                Console.WriteLine("The Monster is confused!");
            }
            gameCounter = gameCounter - 1;
        }

        // Output
        if (knightHP < monsterHP)
        {
            Console.WriteLine("Oh no! You were defeated!");
        }
        else if (monsterHP < knightHP)
        {
            Console.WriteLine("You are victorious!");
        }
        else
        {
            Console.WriteLine("A friendship has been formed!");
        }

    }
}
