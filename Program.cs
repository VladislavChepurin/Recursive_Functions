using System;

class MainClass
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Напишите что-то");

		string str = Console.ReadLine();

		Console.WriteLine("Укажите глубину эха");

		int deep = int.Parse(Console.ReadLine() ?? "0");

		Echo(str, deep);
	}

	static void Echo(string saidword, int deep)
	{
		Console.BackgroundColor = (ConsoleColor)deep;
		Console.WriteLine(saidword);
		if (saidword.Length > 2)
		{
			saidword = saidword.Remove(0, 2);
		}

		if (deep > 1)
		{
			Echo(saidword, --deep);
		}
	}
}