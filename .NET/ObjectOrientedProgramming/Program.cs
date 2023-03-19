using ObjectOrientedProgramming.Interfaces;
using ObjectOrientedProgramming.Objects;

namespace ObjectOrientedProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OOP - Object Oriented Programming");

            int id = 1;
            string email = "michaelJordan@learnxr.io";
            string firstName = "Michael";
            string lastName = "Jodan";

            Console.WriteLine("\nCreating Player 1");

            // creating 1st player
            Player player1 = new Player(id, email, firstName, lastName);
            Console.WriteLine($"Player (1) Full Name: {player1.FullName}");

            player1.FindEnemiesInCloseProximity();
            string firstNameWithFirstLast = player1
                .FirstNameWithFirstLastCharacter;
            
            Console.WriteLine($"Player (1) FirstName & First Character Of Last: {firstNameWithFirstLast}");

            Console.WriteLine("\nCreating Player 2");
            // creating 2nd player
            Player player2 = new Player(++id, email + "c");

            Console.WriteLine("\nCreating Player 3");
            // creating 3rd player
            Player player3 = new Player(++id, email + "d", "Steve", "Jobs");
            player3.MovePlayer(new Vector3(30.0f, 5.0f, 100.0f));
            Console.WriteLine($"Player (3) User Id : {player3.Id}");
            player3.WhoAmI();

            Console.WriteLine("\nCreating Player 4");
            // convert a child object to a parent object
            Player player4 = new Player(++id, email + "e", "Clara", "Toner");
            
            User player4UserInfo = (User)player4;
            player4UserInfo.WhoAmI();

            Console.WriteLine("\nCreating Player 5");
            IPlayer normalPlayer = new Player(++id, email + "f");

            Console.WriteLine("\nCreating Xbox Player");
            IPlayer xboxPlayer = new XboxPlayer();

            MovePlayers(new IPlayer[] { normalPlayer, xboxPlayer });
        }

        static void MovePlayers(IPlayer[] players)
        { 
            foreach(IPlayer player in players)
            {
                player.MovePlayer(new Vector3(0, 0, 0));
            }
        }
    }
}

// Object -> Player
// User Id (User Object)
// Email (string)
// Position (Vector3 Object)
// Full Name (string)
// First Name (string)
// Last Name (string)
// MovePlayer(Vector3) -> Method
// User (User Object)

// public
// private
// protected