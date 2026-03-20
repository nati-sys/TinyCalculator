Console.WriteLine("== Tiny calculator ==");

Console.ForegroundColor = ConsoleColor.Magenta;
Console.Write("1. Operand: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("2. Operand: ");
int b = Convert.ToInt32(Console.ReadLine());
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
    Console.WriteLine($"{a} / {b} = {(double)a / b}");
}
Console.ResetColor();