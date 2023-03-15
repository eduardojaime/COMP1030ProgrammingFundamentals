namespace lesson09b;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, BlackJack!");
        // INPUTS
        // variables that affect the scores
        Random cardDealer = new Random();
        int currentCard = 0;
        int playerScore = 0;
        int computerScore = 0;
        // variables that affect the inner game loop
        bool anotherCard = true;
        string choiceCard = "";
        // variables that affect the main game loop
        bool anotherGame = true;
        string choiceGame = "";

        // PROCESS
        // main game loop (round)
        //  inner game loop (player)
        //      give user a card and increase score
        //      ask if user wants another card
        //  generate computer score

        // OUTPUTS
        //  determine winner and show a message
        //  instant win = 21
        //  instant lose > 21
        //  tie comp = player
        //  normal win player > comp
        //  normal lose comp > player and everything else I didn't cover

        //  ask player if they want to play again
        //  yes > repeat game loop
        //  no > show goodbye message and end
    }
}
