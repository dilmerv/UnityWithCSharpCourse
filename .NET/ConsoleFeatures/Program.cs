Console.WriteLine("Console Features");

Console.Beep();

Console.BackgroundColor = ConsoleColor.Green;
Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine($"Windows Height: {Console.WindowHeight}");
Console.WriteLine($"Windows Width: {Console.WindowWidth}");

Console.BackgroundColor = ConsoleColor.Blue;
Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine($"Windows Largest Height: {Console.LargestWindowWidth}");
Console.WriteLine($"Windows Largest Width: {Console.LargestWindowWidth}");

Console.CancelKeyPress += (x, y) =>
{
    Console.WriteLine("The input was cancelled");
};

Console.WriteLine("\n\nWhat is your age?");
string inputAge = Console.ReadLine() ?? string.Empty;
Console.WriteLine($"The age entered was: {inputAge}");

