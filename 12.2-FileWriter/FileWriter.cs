using System;
using System.IO;

class FileWriter {
	public static void Main() {
		StreamWriter writer = new StreamWriter("../../namn.txt");

		writer.WriteLine("Anna");
		writer.WriteLine("Bertil");
		writer.WriteLine("Catrin");
		writer.WriteLine("David");
		writer.WriteLine("Estelle");
		writer.WriteLine("Fredrik");

		writer.Close();

		Console.WriteLine("Allt klart....");
	}
}
