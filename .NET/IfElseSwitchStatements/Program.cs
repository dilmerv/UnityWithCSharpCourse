namespace IfElseSwitchStatements
{
    internal class Program
    {
        const decimal MAX_PLAYER_POINTS = 1000;
        const decimal PLAYER_POINTS_TIER = 50;

        static void Main(string[] args)
        {
            Console.WriteLine("If Else Switch Statements");
            Console.WriteLine("\n");

            IfElseFirstExample();
            
            Console.WriteLine("\n");

            IfElseIfSecondExample();

            Console.WriteLine("\n");

            SwitchCaseExample("n");
        }

        private static void SwitchCaseExample(string gender)
        {
            gender = gender.ToUpper();

            switch (gender)
            {
                case "F":
                    Console.WriteLine("Female");
                    break;
                case "M":
                    Console.WriteLine("Male");
                    break;
                case "N":
                    Console.WriteLine("Not Provided");
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
        }

        private static void IfElseIfSecondExample()
        {
            decimal currentPlayerPoints = 1000 + 51;

            if (currentPlayerPoints == MAX_PLAYER_POINTS)
            {
                Console.WriteLine("Congratulation player you reached the max amount of points. You " +
                        "now may advance to the next level !!!");
            }
            else if (currentPlayerPoints > MAX_PLAYER_POINTS &&
                currentPlayerPoints <= MAX_PLAYER_POINTS + PLAYER_POINTS_TIER)
            {
                Console.WriteLine("Congratulation player you reached the max + 50 amount of points. You " +
                            "now may advance to the next level !!!");
            }
            else if (currentPlayerPoints > MAX_PLAYER_POINTS + PLAYER_POINTS_TIER)
            {
                Console.WriteLine("Congratulation player you reached the ultimate max");
            }
        }

        private static void IfElseFirstExample()
        {
            decimal currentPlayerPoints = 2000;

            if (currentPlayerPoints >= MAX_PLAYER_POINTS)
            {
                Console.WriteLine("Congratulation player you reached the max amount of points. You " +
                    "now may advance to the next level !!!");
            }
            else
            {
                Console.WriteLine($"Player keep working hard, you still " +
                    $"have {MAX_PLAYER_POINTS - currentPlayerPoints} points remaining...");
            }
        }
    }
}