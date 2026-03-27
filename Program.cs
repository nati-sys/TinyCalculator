using System;
using System.Globalization;
using System;
using System.Globalization;
using System;
using System.Globalization;
using System;
using System.Globalization;
using System;
using System.Globalization;
	using System;
using System.Globalization;
using System.Text;

Console.WriteLine("== Tiny calculator ==");
Console.OutputEncoding = Encoding.UTF8;

RunCalculator();

static void RunCalculator()
{
	Console.ForegroundColor = ConsoleColor.Magenta;
	double current = ReadOperand("Operand 1");
	double next = ReadOperand("Operand 2");
	Console.ResetColor();

	while (true)
	{
		var results = PrintResults(current, next);

		Console.ForegroundColor = ConsoleColor.White;
		Console.WriteLine();
		Console.WriteLine($"Aktueller Wert: {FormatNumber(current)}   Neuer Operand: {FormatNumber(next)}");
		Console.Write("Wähle Ergebnis zum Weiterrechnen (1-4), ");
		Console.Write("'r' neu starten, 'n' neuer Operand, 'q' beenden: ");
		Console.ResetColor();

		var choice = Console.ReadLine()?.Trim().ToLowerInvariant();
		if (string.IsNullOrEmpty(choice))
			continue;

		if (choice == "q")
			return;

		if (choice == "r")
		{
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.Magenta;
			current = ReadOperand("Operand 1");
			next = ReadOperand("Operand 2");
			Console.ResetColor();
			continue;
		}

		if (choice == "n")
		{
			next = ReadOperand("Neuer Operand");
			continue;
		}

		if (int.TryParse(choice, out int idx) && idx >= 1 && idx <= 4)
		{
			double chosen = results[idx - 1];
			if (double.IsNaN(chosen))
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("Ausgewähltes Ergebnis ist undefiniert (z. B. Division durch 0). Wähle etwas anderes.");
				Console.ResetColor();
				continue;
			}
			current = chosen;
			// nach Wahl neuen Operand einlesen
			next = ReadOperand("Weiter mit Operand");
			continue;
		}

		Console.ForegroundColor = ConsoleColor.Red;
		Console.WriteLine("Ungültige Eingabe. Bitte 1-4, r, n oder q eingeben.");
		Console.ResetColor();
	}
}

static double[] PrintResults(double a, double b)
{
	double add = a + b;
	double sub = a - b;
	double mul = a * b;
	double div = double.NaN;
	if (b != 0.0)
		div = a / b;

	Console.ForegroundColor = ConsoleColor.Cyan;
	Console.WriteLine($"1) {FormatNumber(a)} + {FormatNumber(b)} = {FormatNumber(add)}");
	Console.ForegroundColor = ConsoleColor.Yellow;
	Console.WriteLine($"2) {FormatNumber(a)} - {FormatNumber(b)} = {FormatNumber(sub)}");
	Console.ForegroundColor = ConsoleColor.Red;
	Console.WriteLine($"3) {FormatNumber(a)} * {FormatNumber(b)} = {FormatNumber(mul)}");
	Console.ForegroundColor = ConsoleColor.Blue;
	Console.WriteLine($"4) {FormatNumber(a)} / {FormatNumber(b)} = {FormatNumber(div)}");
	Console.ResetColor();

	return new[] { add, sub, mul, div };
}

static double ReadOperand(string title)
{
	Console.ForegroundColor = ConsoleColor.Magenta;
	Console.Write($"{title}: ");
	Console.ResetColor();

	while (true)
	{
		var input = Console.ReadLine();
		if (double.TryParse(input, NumberStyles.Float | NumberStyles.AllowThousands, CultureInfo.CurrentCulture, out double val))
			return val;

		Console.ForegroundColor = ConsoleColor.Red;
		Console.WriteLine($"FEHLER: {title} ist keine Zahl.");
		Console.ResetColor();
		Console.ForegroundColor = ConsoleColor.Magenta;
		Console.Write($"{title}: ");
		Console.ResetColor();
	}
}

static string FormatNumber(double v)
{
	if (double.IsNaN(v))
		return "undefiniert";
	if (double.IsPositiveInfinity(v))
		return "∞";
	if (double.IsNegativeInfinity(v))
		return "-∞";
	// Use current culture formatting
	return v.ToString("G", CultureInfo.CurrentCulture);
}