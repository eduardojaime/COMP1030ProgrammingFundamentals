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

        // Q1 How to solve CS8602 error for dereference of null reference?
        // Message is shown because there could be a possible null value returned
        // Use '!' after ReadLine() to indicates that the method can return a NULL value
        string myOption = Console.ReadLine()!.Trim().ToUpper();

    }
}
