using System;

class FunktionIndata {
	static void Main() {
		summeraTal(10, 23);
	}

	static void summeraTal(int tal_1, int tal_2) {
		int summa = tal_1 + tal_2;

		Console.WriteLine("Summan av " + tal_1 + " + " + tal_2 + " = " + summa);
	}
}
