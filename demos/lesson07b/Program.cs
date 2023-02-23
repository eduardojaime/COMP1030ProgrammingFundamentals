using System.Linq;
namespace lesson07b;
class Program
{
    static void Main(string[] args)
    {
        // Adventure game
        // Knight vs Monster
        // Every turn player chooses to attack or heal
        // Every turn monster randomly chooses to attack or heal
        // In order to win the player must reduce the monster's health to <= 0
        // Intro and instructions
        Console.WriteLine("Welcome to Monster Fight!");
        Console.WriteLine("This is a very dangerous land, and it's full of monsters so be careful!");
        Console.WriteLine("Every turn you may Attack (A) or Heal (H)");
        Console.WriteLine("Your travel begins now!");
        // Setup the game
        int playerHP = 100;
        int monsterHP = 100;
        // Basic game loop
        // INPUT > PROCESS > OUTPUT > REPEAT?
        // flag to indicate whether we play another round
        bool continuePlaying = true; // set to true to enter the loop the first time

        while (continuePlaying == true)
        {
            // INPUT
            Console.WriteLine("Do you want to Attack (A) or Heal (H)?");
            string playerMove = Console.ReadLine().Trim().ToUpper();
            string monsterMove = "A"; // TODO make this random
            // PROCESS
            if (playerMove == "A")
            {
                monsterHP = monsterHP - 10;
                Console.WriteLine("You have attacked with your sword!");
            }
            else if (playerMove == "H")
            {
                playerHP = playerHP + 20;
                Console.WriteLine("You drank a potion!");
            }
            else
            {
                Console.WriteLine("You look confused!");
            }

            if (monsterMove == "A")
            {
                playerHP = playerHP - 15;
                Console.WriteLine("Monster attacked you with their club and scratched you with their claws!");
            }
            else if (monsterMove == "H")
            {
                monsterHP = monsterHP + 20;
                Console.WriteLine("Monster ate a healing mushroom!");
            }
            else
            {
                Console.WriteLine("Monster is confused in the battlefield!");
            }
            Console.WriteLine($"PlayerHP: {playerHP.ToString()} - MonsterHP: {monsterHP.ToString()}");
            // OUTPUT
            if (playerHP <= 0) {
                Console.WriteLine("Oh no, you and your friends are defeated!");
            }
            else if (monsterHP <= 0) {
                Console.WriteLine("You are victorious!");
            }
            else {
                continue; // skips the rest of the code, it won't ask the user for another round yet
            }
            // REPEAT?
            Console.WriteLine("Do you want to play another round? Press Y to continue. ANY other key will exit the game.");
            string answer = Console.ReadLine().Trim().ToUpper(); // cleanup user input
            if (answer == "Y")
            {
                continuePlaying = true;
            }
            else
            {
                continuePlaying = false;
            }
        }
        Console.WriteLine("Thank you for playing!");
    }
}
