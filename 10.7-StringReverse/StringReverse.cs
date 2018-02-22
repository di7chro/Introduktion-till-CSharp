using System;

class StringReverse {
	public static void Main() {
		string s = "Norrsken";
		string reversed;

		reversed = StupidReverse(s);
		Console.WriteLine("StupidReverse: " + reversed);

		reversed = GoodReverse(s);
		Console.WriteLine("GoodReverse: " + reversed);
	}

	static string StupidReverse(string text) {
		char[] charArray = text.ToCharArray();
		string reverse = String.Empty;

		for (int i = charArray.Length - 1; i >= 0; i--) {
			reverse += charArray[i];
		}
		return reverse;
	}

	static string GoodReverse(string text) {
		char[] charArray = text.ToCharArray();
		Array.Reverse(charArray);
		return new string(charArray);
	}
}
