using System;

class Hypotenusa {
	public static void Main() {
		double svaret;

		svaret = rakna_hypotenusa(3, 4);

		Console.WriteLine("Langsidan i triangeln blir: {0}", svaret);	
	}

	static double rakna_hypotenusa(double a, double b) {
		double kvadrater = Math.Pow(a, 2) + Math.Pow(b, 2);
		double sidan = Math.Sqrt(kvadrater);

		return sidan;
	}
}
