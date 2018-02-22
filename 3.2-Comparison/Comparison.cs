using System;

class Comparison {
	public static void Main() {
		int a = 10, b = 15, c = 5;
		float f = 5.0000000001f;

		Console.WriteLine("a < b : {0}", a < b);
		Console.WriteLine("a > b : {0}", a > b);

		Console.WriteLine("a == b : {0}", a == b);
		Console.WriteLine("a != b : {0}", a != b);

		Console.WriteLine("b == a+c : {0}", b == a + c);

		Console.WriteLine("c == f : {0}", c == f);
	}
}
