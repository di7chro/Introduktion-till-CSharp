using System;

class SubString {
	public static void Main() {
		string s1 = "C:/Users/Crille/Desktop/profilbild.jpg";

		Console.WriteLine("Filandelse: " + s1.Substring(s1.Length - 3, 3));

		int username_start = s1.IndexOf('/', 3) + 1;
		int username_end = s1.IndexOf('/', username_start + 1);
		int username_length = username_end - username_start;

		Console.WriteLine("Start: {0}, End: {1}, Length: {2}", username_start, username_end, username_length);
		Console.WriteLine("Username: " + s1.Substring(username_start, username_length));
	}
}
