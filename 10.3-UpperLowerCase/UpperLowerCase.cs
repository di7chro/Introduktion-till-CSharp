using System;

class UpperLowerCase {
	public static void Main() {
		string s1 = "      ThIS iS jUSt a NORmal pieCe Of TexT.       ";

		Console.WriteLine(s1);
		Console.WriteLine(s1.ToUpper());
		Console.WriteLine(s1.ToLower());

		Console.WriteLine(s1.TrimEnd());
		Console.WriteLine(s1.TrimStart());
		Console.WriteLine(s1.Trim());
	}
}
