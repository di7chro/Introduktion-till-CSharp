using System;

class TypKonverteringar {
	public static void Main() {
		string text = "Hejsan på dig lille vän";

		Console.WriteLine("sizeof(int): {0}, typeof(int): {1}", sizeof(int), typeof(int));
		Console.WriteLine("sizeof(long): {0}, typeof(long): {1}", sizeof(long), typeof(long));
		Console.WriteLine("sizeof(byte): {0}, typeof(byte): {1}", sizeof(byte), typeof(byte));
		Console.WriteLine("sizeof(float): {0}, typeof(float): {1}", sizeof(float), typeof(float));
		Console.WriteLine("sizeof(double): {0}, typeof(double): {1}", sizeof(double), typeof(double));
		Console.WriteLine("sizeof(char): {0}, typeof(char): {1}", sizeof(char), typeof(char));

		Console.WriteLine("String: " + text.Length);

		int i = 10;
		float f = 17.5f;
		Console.WriteLine("i+f={0}", i + f);

		int svar;
		svar = i - (int)f;
		Console.WriteLine("Svar: {0}", svar);
	}
}
