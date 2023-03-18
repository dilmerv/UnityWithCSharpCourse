using System.Reflection.Metadata;

namespace LoopsFeatures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loops Features");

            int low = 0;
            int high = 10;

            // for loops from low to high
            Console.WriteLine("\nFor Loop Low To High:");
            for (int i = low; i < high; i++)
            {
                Console.WriteLine(i);
            }

            // for loops from high to low
            Console.WriteLine("\nFor Loop Low To High:");
            for (int j = high; low <= j - 1; j--)
            {
                Console.WriteLine(j - 1);
            }

            // while loop
            Console.WriteLine("\nWhile Loop With Incrementer:");
            int whileHigh = 10;
            int whileIncrementer = 0;

            while (whileIncrementer < whileHigh)
            {
                Console.WriteLine(whileIncrementer++);
            }

            Console.WriteLine("\nDo While Loop With Incrementer:");
            int doWhileHigh = 10;
            int doWhileIncrementer = 0;
            do
            {
                Console.WriteLine(doWhileIncrementer++);
            } 
            while (doWhileIncrementer < doWhileHigh);

            Console.WriteLine("\nFor Each Loop:");
            string[] players = new string[] { "Player 1", "Player 2", 
                "Player 3", "Player 4" };

            foreach (string player in players)
            {
                Console.WriteLine($"{player}");
            }

            for (int i = 0; i < players.Length; i++)
            {
                Console.WriteLine(players[i]);
            }

            List<int> playerScores = new List<int>();
            playerScores.Add(200);
            playerScores.Add(300);
            
            foreach (var score in playerScores)
            {
                Console.WriteLine($"{score}");
            }
        }
    }
}