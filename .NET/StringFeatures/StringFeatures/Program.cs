Console.WriteLine("String Features");

// string joining
string x = "Hello";
string y = "World!";
string helloWorld = x + " " + y;
string helloWorldTest2 = string.Concat(x, " ", y, " from space");

// string interpolation
string helloWorldClean = $"{x} {y} from mars";

// string replacements
string planet = "jupiter";
string star = "     the moon   ";

string sentence = $"I would love to go to {planet}";
Console.WriteLine("Sentence: " + sentence);
string modifiedSetence = sentence.Replace(planet, star);
Console.WriteLine("ModifiedSetence: " + modifiedSetence);

// string trims
star = star.Trim();

string modifiedSetence2 = sentence.Replace(planet, star);
Console.WriteLine("modifiedSetence2: " + modifiedSetence2);

// string chars
char grabOneLetter = planet[1];

int lengthOfPlanetWord = planet.Length;

Console.ReadLine();