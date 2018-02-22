using System;

class DivByZero {
	public static void Main() {
		float t = 5, n = 0, svar = 0;

		try {
			if (n == 0)
				throw new DivideByZeroException();
			svar = t / n;
			Console.WriteLine("Svar: {0}", svar);
		}
		catch (DivideByZeroException dbz) {
			Console.WriteLine("Du kan inte dela med 0! Larde du dig inget i 2:an???");
			Console.WriteLine(dbz);
		}
		finally {
			Console.WriteLine("Finally kors alltid. Bra stalle att stada efter sig.");
		}
	}
}
