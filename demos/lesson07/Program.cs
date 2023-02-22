namespace lesson07;
class Program
{
    static void Main(string[] args)
    {
        // Adventure game
        // Knight vs Monster
        // Every turn player will choose to attack or heal
        // Every turn Monster attacks or heals
        // In order to win the player must reduce the monster's health to < 0

        // Instructions and Story
        Console.WriteLine("Welcome to Monster Fight!!");
        Console.WriteLine("This is a very dangerous land, full of monsters so be careful!");
        Console.WriteLine("Every turn you can choose to Heal (H) or Attack (A)");

        // Set up game
        int playerHP = 100;
        int monsterHP = 100;

        // Game loop
        // INPUT > PROCESS > OUTPUT > REPEAT?
        bool continuePlaying = true;

        Console.WriteLine("Look out! A monster has appeared!");
        while (continuePlaying)
        {
            // do another round

            // INPUT
            Console.WriteLine("Do you wish to Heal (H) or Attack (A)?");
            string playerMove = Console.ReadLine().Trim().ToUpper(); // clean up user input from the console
            string monsterMove = "A"; // TODO make this random

            // PROCESS
            if (playerMove == "A")
            {
                Console.WriteLine("You used your sword!");
                monsterHP = monsterHP - 20;
            }
            else if (playerMove == "H")
            {
                Console.WriteLine("You drank a potion!");
                playerHP = playerHP + 30;
            }
            else
            {
                Console.WriteLine("You look confused!");
            }

            if (monsterMove == "A")
            {
                Console.WriteLine("Monster attacked you with their club, and scratched you with their claws!");
                playerHP = playerHP - 25;
            }
            else if (monsterMove == "H")
            {
                Console.WriteLine("Monster used a wild mushroom!");
                monsterHP = monsterHP + 30;
            }
            else
            {
                Console.WriteLine("Monster made a weird noise!");
            }

            Console.WriteLine($"PlayerHP: {playerHP.ToString()} MonsterHP: {monsterHP.ToString()}");

            // OUTPUT
            if (playerHP <= 0)
            {
                Console.WriteLine("Oh now, you were defeated!");
                // check if user wants to play again
                Console.WriteLine("Do you want to play another round? Press Y to continue.");
                string answer = Console.ReadLine().Trim().ToUpper();
                if (answer == "Y")
                {
                    continuePlaying = true;
                    monsterHP = 100;
                    playerHP = 100;
                }
                else
                {
                    continuePlaying = false;
                }
            }
            else if (monsterHP <= 0)
            {
                Console.WriteLine("You were victorious!");
                // check if user wants to play again
                Console.WriteLine("Do you want to play another round? Press Y to continue.");
                string answer = Console.ReadLine().Trim().ToUpper();
                if (answer == "Y")
                {
                    continuePlaying = true;
                    monsterHP = 100;
                    playerHP = 100;
                }
                else
                {
                    continuePlaying = false;
                }
            }
        }
    }
}
