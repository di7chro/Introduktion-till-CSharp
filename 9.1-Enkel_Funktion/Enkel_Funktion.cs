using System;

class Enkel_Funktion {
	public static void PrintCompany() {
		Console.WriteLine("===================================");
		Console.WriteLine("| Catrins Fruktaffar AB           |");
		Console.WriteLine("| Hemgatan 1                      |");
		Console.WriteLine("| 123 45 Bortistan                |");
		Console.WriteLine("===================================");
	}

	public static void Main() {
		Console.WriteLine("Nu skall vi anropa en funktion");

		PrintCompany();

		Console.WriteLine("funkar det en gang till?");
		for (int i = 0; i < 5; i++) {
			Console.WriteLine("Anropar funktionen: " + i);
			PrintCompany();
		}
	}
}
