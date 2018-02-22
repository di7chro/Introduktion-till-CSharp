using System;

class Overload {
	public static void Main() {
		PrintInfo();
		PrintInfo(5);
		PrintInfo(5, "Kalle");
		PrintInfo("Lisa", 5);
	}

	static void PrintInfo() {
		Console.WriteLine("Jag skriver inte ut nagot alls.");
	}

	static void PrintInfo(int tal) {
		Console.WriteLine("Ett tal: " + tal);
	}

	static void PrintInfo(int tal, string namn) {
		Console.WriteLine("Ett tal: " + tal + " och namnet:" + namn);
	}

	static void PrintInfo(string namn, int tal) {
		Console.WriteLine("Denna tar emot en strang: " + namn + " och talet: " + tal);
	}
}
