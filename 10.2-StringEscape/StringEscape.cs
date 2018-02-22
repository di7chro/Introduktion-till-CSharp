using System;

class StringEscape {
	public static void Main() {
		string s1 = "This is just a piece of text";
		Console.WriteLine(s1);

		string s2 = "Double quotes (\") is important and backslash (\\) too.";
		Console.WriteLine(s2);

		string s3 = "This is a very long line \nof test that should be on two lines.";
		Console.WriteLine(s3);

		string s4 = "Anna \t65 \tGDFS";
		string s5 = "Bertil \t54 \tFDSA";
		string s6 = "Catrin \t12 \tSG";
		string s7 = "David \t57 \tGF";

		Console.WriteLine("==================================");
		Console.WriteLine(s4);
		Console.WriteLine(s5);
		Console.WriteLine(s6);
		Console.WriteLine(s7);
	}
}
