Console.WriteLine("C# Operators");

// + = - / % ++ --
int x = 12;
x += 12;
x += 12;

int y = x;
y -= 12;

int total = x + y;

Console.WriteLine($"x: {x}");
Console.WriteLine($"y: {y}");
Console.WriteLine($"total: {total}");

int i = 0;
int b = 0;
Console.WriteLine($"i: {i++}");
Console.WriteLine($"i: {i}");
Console.WriteLine($"b: {++b}");

// == != > < >= <=

int someVar = 0;
int c = (1 > someVar) ? 20 : 10;

Console.WriteLine($"c: {c}");

// && || !
int d = ((1 == someVar || 1 == 1) && 1 == 1) ? 20 : 10;
Console.WriteLine($"d: {d}");

