using System;

class IndexOf {
	public static void Main() {
		string s1 = "Denna text kan man leka med en stund.";

		Console.WriteLine(s1.IndexOf("te"));
		Console.WriteLine(s1.IndexOf("yhfdsnhbvfd"));
		Console.WriteLine(s1.IndexOf("De"));
		Console.WriteLine(s1.IndexOf("k"));
		Console.WriteLine(s1.IndexOf("k", 12));
	}
}
