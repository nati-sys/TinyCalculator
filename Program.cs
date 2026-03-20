Console.WriteLine("== Tiny calculator ==");

Console.ForegroundColor = ConsoleColor.Magenta;
int a = ReadOperand("Operand 1");
int b = ReadOperand("Operand 2");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($"{a} + {b} = {a + b}");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"{a} - {b} = {a - b}");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"{a} * {b} = {a * b}");
Console.ForegroundColor = ConsoleColor.Blue;
if (b == 0)
{
    Console.WriteLine($"{a} / {b} = undefiniert/unendlich");
}
else
{
    Console.WriteLine($"{a} / {b} = {a / b}");
}

static int ReadOperand(string title)
{
    Console.Write($"{title}: ");
    int a;
    while (!int.TryParse(Console.ReadLine(), out a))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"FEHELER: {title} ist keine Zahl.");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write($"{title}: ");
    }
    return a;
}