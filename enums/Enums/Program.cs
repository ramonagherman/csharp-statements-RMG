using System;

public class Program
{
	static void Main(string[] args)
	{
		string[] formats = { "G", "g", "F", "f", "D", "d", "X", "x" };

		foreach (string format in formats)
		{
			Console.WriteLine(FormatDayOfWeek(DayOfWeek.Friday, format));
		}
	}

	public static string FormatDayOfWeek(DayOfWeek value, string format)
	{
		if (string.IsNullOrWhiteSpace(format))
		{
			format = "G";
		}

		return Enum.Format(typeof(DayOfWeek), value, format);
	}
}

[Flags]
public enum DayOfWeek
{
	None = 0b_0000_0000,
	Monday = 0b_0000_0001,
	Tuesday = 0b_0000_0010,
	Wednesday = 0b_0000_0100,
	Thursday = 0b_0000_1000,
	Friday = 0b_0001_0000,
	Saturday = 0b_0010_0000,
	Sunday = 0b_0100_0000
}