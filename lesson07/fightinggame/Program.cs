namespace fightinggame;
class Program
{
    static void Main(string[] args)
    {
        // Considerations:
        // I will start with a basic program with only 1 file
        // Rules:
        // Knight vs Monster
        // Every turn player will choose to attack or heal
        // Every turn Monster will attack or heal the player
        // In order to win the player must reduce the monster's health to < 0

        // Instructions
        Console.WriteLine("Welcome to Monster Fight!!");
        Console.WriteLine("In this adventure you are playing the Knight");
        Console.WriteLine("Many Monsters live in this land so be careful!");
        Console.WriteLine("Every turn you can choose to heal (H) or attack (A)"); // game choices
        Console.WriteLine("But be careful! Monsters will also heal or attack!");
        Console.WriteLine("");

        // Input
        int knightHP = 100;
        int monsterHP = 100; // MAGIC POWER, SPECIALS 

        Console.WriteLine("A Monster has appeared!");

        int gameCounter = 5;
        while (gameCounter > 0)
        {

            Console.WriteLine("Do you wish to heal (H) or attack (A)?");
            string userSelection = Console.ReadLine();
            string monsterSelection = "A"; // monster always attack for now

            // Process
            if (userSelection.ToUpper() == "A")
            {
                monsterHP = monsterHP - 20;
                Console.WriteLine("You used your sword to attack the monster!");
            }
            else if (userSelection.ToUpper() == "H")
            {
                knightHP = knightHP + 20; // for now they can heal themselves more than 100 HP
                Console.WriteLine("A magic potion has restored 20 HP!");
            }
            else
            {
                Console.WriteLine("The Knight looks confused!");
            }

            if (monsterSelection == "A")
            {
                knightHP = knightHP - 10;
                Console.WriteLine("Monster used their club to attack you!");
            }
            else if (monsterSelection == "H")
            {
                monsterHP = monsterHP + 20;
                Console.WriteLine("Monster used a wild mushroom to heal themselves!");
            }
            else
            {
                Console.WriteLine("Monster looks confused!");
            }
            // decrease counter
            gameCounter--;
        }

        // Output
        if (knightHP < monsterHP)
        {
            Console.WriteLine("Oh no! You have been defeated!");
        }
        else if (monsterHP < knightHP)
        {
            Console.WriteLine("You are victorious!");
        }
        else
        {
            Console.WriteLine("What a battle! This is a tie!");
        }
    }
}
