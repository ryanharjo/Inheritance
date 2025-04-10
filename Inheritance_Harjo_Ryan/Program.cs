namespace Inheritance_Harjo_Ryan
{
    // Main entry point of the program
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Horror game
            Horror myHorror = new Horror("M", "Resident Evil");

            // Call the Describe method to get game info
            Console.WriteLine(myHorror.Describe());
            // Start the game
            myHorror.PlayGame();


        }


    }
}
