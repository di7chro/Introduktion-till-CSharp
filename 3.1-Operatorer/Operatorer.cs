using System;

class Operatorer {
	public static void Main() {
		int a = 1;
		float f = 45f;
		/*
		Console.WriteLine("Plus: {0}", 3 + 4);
		Console.WriteLine("Plus: {0}", 3 - 4);
		Console.WriteLine("Plus: {0}", 3 * 4);
		Console.WriteLine("Plus: {0}", 3f / 4f);
		*/
		a += 5;
		//Console.WriteLine("A: " + a);
		a -= 5;
		//Console.WriteLine("A: " + a);
		a *= 5;
		//Console.WriteLine("A: " + a);
		a /= 5;
		//Console.WriteLine("A: " + a);

		a = 5;
		Console.WriteLine("A före: " + a);
		Console.WriteLine("A efter: " + --a);
		Console.WriteLine("A sist: " + a);

		/*
		f /= 26;
		Console.WriteLine("f: " + f);
		Console.WriteLine("f: {0:0.000}", f);
		*/
	}
}
