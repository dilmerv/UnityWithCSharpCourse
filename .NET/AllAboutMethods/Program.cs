using System.Reflection.Metadata;

namespace AllAboutMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("All About Methods");

            DisplayPlayerNameAndAge();
            DisplayPlayerName();

            string playerName = GetPlayerName();
            Console.WriteLine($"Displaying The Player with Name: {playerName}");

            DisplayPlayerNameAndAge("Karl Malone", 55);

            Console.WriteLine($"Displaying The Player with Name: {GetPlayerName("_")}");
        }

        static void DisplayPlayerNameAndAge()
        {
            string playerName = "Michael Jordan";
            string playerAge = "35";
            Console.WriteLine($"Displaying The Age: {playerAge} Of A Player with Name: {playerName}");
        }

        static void DisplayPlayerNameAndAge(string playerName, int age)
        {
            Console.WriteLine($"Displaying The Age: {age} Of A Player with Name: {playerName}");
        }

        static void DisplayPlayerName()
        {
            string playerName = "Michael Jordan";
            Console.WriteLine($"Displaying The Player with Name: {playerName}");
        }

        static string GetPlayerName(string separator)
        {
            return $"John{separator}Doe";
        }

        static string GetPlayerName()
        {
            string playerName = "John Doe";
            return playerName;
        }
    }
}