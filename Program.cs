Console.WriteLine("== Tiny calculator ==");

Console.ForegroundColor = ConsoleColor.Magenta;
Console.Write("1. Operand: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("2. Operand: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.ResetColor();
Console.WriteLine($"{a} + {b} = {a + b}");
Console.WriteLine($"{a} - {b} = {a - b}");
Console.WriteLine($"{a} * {b} = {a * b}");
if (b == 0)
{
    Console.WriteLine($"{a} / {b} = undefiniert/unendlich");
}
else
{
    Console.WriteLine($"{a} / {b} = {a / b}");
}