namespace GameExample;
class Program
{
    // Part of the Rubric > 10 marks
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        bool keepPlaying = true;

        // You should call game related methods from here
        Game myGame = new Game(2, "easy");
        myGame.StartGame();
        while (keepPlaying)
        {
            myGame.PlayTurn();
            keepPlaying = false;
        }
        myGame.DetermineResult();

    }
}
