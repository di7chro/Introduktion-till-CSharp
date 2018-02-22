using System;

class StringPrint {
	public static void Main() {
		string message = "This is just a normal string.";

		Console.WriteLine("Message: " + message);
		Console.WriteLine("Message: {0}", message);
		Console.WriteLine("Langd: {0}", message.Length);

		for (int i = 0; i < message.Length; i++) {
			Console.WriteLine("message[{0}]: {1}", i, message[i]);
		}
	}
}
