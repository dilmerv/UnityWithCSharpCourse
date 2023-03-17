using System.Globalization;

Console.WriteLine("Parsing And Casting Features");

string ageStr = "36";
string addedAgeStr = "10";
int totalAge = int.Parse(ageStr) + int.Parse(addedAgeStr);

string weightStr = "203.34";
string addedWeightStr = "12.26";
double totalWeight = double.Parse(weightStr) + double.Parse(addedWeightStr);

Console.WriteLine($"New Age: {totalAge}");
Console.WriteLine($"New Weight: {totalWeight}");

// how to fix issues with inputs
string weightStr2 = "200.345";
bool didThisWork = double.TryParse(weightStr2, out double newWeight);

string moneyEarnedStr = "$1000.53";

bool didThisWorkForADecimal = decimal.TryParse(moneyEarnedStr,
    NumberStyles.AllowCurrencySymbol | NumberStyles.AllowDecimalPoint, 
    NumberFormatInfo.CurrentInfo, 
    out decimal moneyEarnedAsDecimal);

Console.WriteLine($"Money Earned As Decimal: {moneyEarnedAsDecimal}");

decimal moneyEarnedRounded = Math.Round(moneyEarnedAsDecimal, 0);

Console.WriteLine($"Money Earned Rounded: {moneyEarnedRounded}");

int moneyEarnedAsInt = (int)moneyEarnedAsDecimal;
float moneyEarnedAsInt2 = (float)moneyEarnedAsDecimal;

Console.ReadLine();