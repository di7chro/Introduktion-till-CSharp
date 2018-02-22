using System;
using System.IO;

class ReadFile {
	public static void Main() {
		StreamReader reader = new StreamReader("../../exempel.txt");
		int lineNumber = 0;
		string line;

		// Läsa in alla rader i en fil
		do {
			line = reader.ReadLine();
			lineNumber++;
			Console.WriteLine("Line:{0}: {1}", lineNumber, line);
		} while(line != null);

		reader.Close();
	}
}
