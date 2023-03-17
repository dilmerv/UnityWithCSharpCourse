class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Declaring Value Types");

        // declare variables
        int age = 25;
        string fullName = "Michael Jordan";
        double weight = 300D;
        long distance = 10L;
        GenderType genderType = GenderType.Male;
        char gender = 'F';
        float playerDistanceAtZ = 11.565433f;
        decimal playerWorth = 1000.000M;

        Console.WriteLine($"Player's Age: {age}");
        Console.WriteLine($"Player's Full Name: {fullName}");
        Console.WriteLine($"Player's Weight: {weight}");
        Console.WriteLine($"Player's Distance Long: {distance}");
        Console.WriteLine($"Player's Gender Type: {genderType}");
        Console.WriteLine($"Player's Gender Char: {gender}");
        Console.WriteLine($"Player's Distance Float: {playerDistanceAtZ}");
        Console.WriteLine($"Player's Worth: {playerWorth}");

        int x = 25, y = 39, z = 25;
        int a, b = 37;
        a = 35;

        Console.WriteLine($"x: {x} y: {y} z: {z} a: {a} b: {b}");

        Console.WriteLine("Declaring Arrays");

        // single dimensional arrays
        int[] ages = new int[] { 12, 13, 14, 15 };
        Console.WriteLine($"{ages[0]} {ages[1]} {ages[2]} {ages[3]}");

        // double dimensional arrays
        // [rows,columns]
        string[,] people = new string[,] { 
                                            {"Michael", "Joe", "Amanda"},
                                            {"Steve", "Vanesa", "Elon"},
                                            {"Julio", "Brunella", "Dilmer"}
                                         };
        Console.WriteLine($"{people[2, 2]}");
        Console.WriteLine($"{people[1, 0]}");
        Console.WriteLine($"{people[0, 0]}");

        Console.WriteLine("Value Types vs Reference Types");

        int secondPlayerAge = 55;
        Console.WriteLine($"Before -> secondPlayerAge: {secondPlayerAge}");
        ValueTypeTesting(secondPlayerAge);
        Console.WriteLine($"After -> secondPlayerAge: {secondPlayerAge}");

        int[] secondSetOfAges = new int[]{ 12, 13, 14 };
        Console.WriteLine($"Before -> secondSetOfAges: {secondSetOfAges[0]}");
        ReferenceTypeTesting(secondSetOfAges);
        Console.WriteLine($"After -> secondSetOfAges: {secondSetOfAges[0]}");

    }

    public static void ValueTypeTesting(int newAge)
    {
        newAge = 89;
    }

    public static void ReferenceTypeTesting(int[] ages)
    {
        if (ages.Length > 0)
        {
            ages[0] = 89;
        }
    }

    enum GenderType
    { 
        Male = 0,
        Female = 1,
        NotProvided = -1
    }
}
