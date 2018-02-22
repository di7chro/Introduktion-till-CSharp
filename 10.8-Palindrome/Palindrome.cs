using System;

class Palindrome {
	public static void Main() {
		string test = "Sallad i Dallas";

		test = test.ToLower();
		Console.WriteLine("Ar texten \"{0}\" ett Palindrom?: {1}", test, isPalindrome(test));
	}

	static bool isPalindrome(string input) {
		int length = input.Length;

		for (int i = 0; i < length / 2; i++) {
			if (input[i] != input[length - i - 1])
				return false;
		}
		return true;
	}
}
