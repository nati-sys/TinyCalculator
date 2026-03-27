using System.Text;

Console.WriteLine("== Tiny calculator ==");

Console.OutputEncoding = Encoding.UTF8;
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
Console.WriteLine($"{a} / {b} = {(double)a / b}");
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine($"{a} ^ {b} = {Math.Pow(a,b)}");
Console.ResetColor();

static int ReadOperand(string title)
{
    Console.Write($"{title}: ");
    int operand;
    while (!int.TryParse(Console.ReadLine(), out operand))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"FEHELER: {title} ist keine Zahl.");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write($"{title}: ");
    }
    return operand;
}